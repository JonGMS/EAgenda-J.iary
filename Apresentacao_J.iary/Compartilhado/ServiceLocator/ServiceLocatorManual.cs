using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Infra_BancoDadosORM_J.iary.ModuloUsuario;
using Aplicacao_J.iary.ModuloUsuario;
using Apresentacao_J.iary.ModuloUsuario;
using Dominio_J.iary.ModuloUsuario;
using Dominio_J.iary.ModuloLogin;
using Infra_BancoDadosORM_J.iary.ModuloTarefa;
using Aplicacao_J.iary.ModuloTarefa;
using Apresentacao_J.iary.ModuloTarefa;
using Apresentacao_J.iary.ModuloInserir;
using Apresentacao_J.iary.ModuloNota;
using Infra_BancoDadosORM_J.iary.ModuloNota;
using Aplicacao_J.iary.ModuloNota;
using Aplicacao_J.iary.ModuloCategoria;
using Apresentacao_J.iary.ModuloCategoria;
using Infra_BancoDadosORM_J.iary.ModuloCategoria;
using Infra_BancoDadosORM_J.iary.ModuloRotina;
using Aplicacao_J.iary.ModuloCofre;
using Apresentacao_J.iary.ModuloCofre;
using Infra_BancoDadosORM_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloCofre;
using Aplicacao_J.iary.ModuloCriptografar;

namespace Apresentacao_J.iary.Compartilhado.ServiceLocator
{
    public class ServiceLocatorManual : IServiceLocator
    {
        private Dictionary<string, Func<Login>> login = new Dictionary<string, Func<Login>>();
        private Dictionary<string, ControladorBase> controladores;
        private Dictionary<string, Action> inserir = new Dictionary<string, Action>();
        private Dictionary<string, Action> Editar = new Dictionary<string, Action>();
        private Dictionary<string, Action> Excluir = new Dictionary<string, Action>();
        private Dictionary<string, Action> Listar = new Dictionary<string, Action>();
        public Cofre cofre;
        private Usuario Logged;
        private UCInserir ucInserir;
        private JiaryDbContext contextoDadosOrm;
        public ServiceLocatorManual()
        {
            InicializarControladores();
        }

        public T Get<T>() where T : ControladorBase
        {
            var tipo = typeof(T);

            var nomeControlador = tipo.Name;

            return (T)controladores[nomeControlador];
        }

        private void InicializarControladores()
        {
            controladores = new Dictionary<string, ControladorBase>();

            //var configuracao = new ConfigurationBuilder()
            //   .SetBasePath(Directory.GetCurrentDirectory())
            //   .AddJsonFile("ConfiguracaoAplicacao.json")
            //   .Build();
            //var config = new ConfiguracaoAplicacao();

            var connectionString = "Server=JOAOGABRIEL22\\SQLEXPRESS;" +
                                    "Database=DB_JIARY;" +
                                    "Trusted_Connection=True;" +
                                    "TrustServerCertificate=True;";
            contextoDadosOrm =  new JiaryDbContext(connectionString);

            var RepositorioUsuario = new RepositorioUsuarioORM(contextoDadosOrm);
            var servicoUsuario = new ServicoUsuario(RepositorioUsuario, contextoDadosOrm);
            var controladorUsuario = new ControladorUsuario(servicoUsuario);
            login["Login"] =controladorUsuario.Login;

            
            //controladores.Add("ControladorTarefa", controladorTarefa);
            //var repositorioTarefa = new RepositorioTarefaORM(contextoDadosOrm);


            //controladores.Add("ControladorConfiguracao", new ControladorConfiguracao(config));
        }

        public bool ExecutarLogin()
        {

            var usuarioLogado = new Login();
            usuarioLogado = login["Login"]();
            Logged = usuarioLogado.Usuario;
            InicializarControladores();
            return usuarioLogado.Logged;
        }

        public void RegistrarTelaInicial(UCTelaInicial telaInicial)
        {
            var ucInserir = new UCInserir(this);
            this.ucInserir = ucInserir;
            controladores["ControladorInserir"] =
                new ControladorInserir(telaInicial, this, ucInserir);

            var repositorioRotina = new RepositorioRotinaORM(contextoDadosOrm);

            var repositorioCofre = new RepositorioCofreORM(contextoDadosOrm);
            var servicoCofre = new ServicoCofre(repositorioCofre, contextoDadosOrm);
            controladores["ControladorCofre"] = new ControladorCofre(this, Logged, servicoCofre);

            var servicoCriptografia = new ServicoCriptografia(Logged.Password);
            var ucTarefa = new UCTarefa(Logged, this);
            var repositorioTarefa = new RepositorioTarefaORM(contextoDadosOrm);
            var servicoTarefa = new ServicoTarefa(repositorioTarefa, contextoDadosOrm, repositorioRotina, servicoCriptografia);
            var controladorTarefa = new ControladorTarefa(ucInserir, servicoTarefa, Logged, this);
            inserir["ControladorTarefa"] = controladorTarefa.Inserir;

            var repositorioCategoria = new RepositorioCategoriaORM(contextoDadosOrm);
            var servicoCategoria = new ServicoCategoria(contextoDadosOrm, repositorioCategoria, contextoDadosOrm);
            var controladorCategoria = new ControladorCategoria(servicoCategoria, Logged);
            inserir["ControladorCategoria"] = controladorCategoria.Inserir;
            controladores["ControladorCategoria"] = controladorCategoria;
            var repositorioNota = new RepositorioNotaORM(contextoDadosOrm);
            var servicoNota = new ServicoNota(contextoDadosOrm, repositorioNota, servicoCriptografia);
            var controladorNota = new ControladorNota(ucInserir, servicoNota, Logged, this, servicoCategoria, servicoTarefa);
            inserir["ControladorNota"] = controladorNota.Inserir;


        }


        public void ExecutarInsercao(string nomeControlador)
        {
            if (nomeControlador == "ControladorTarefa")
            {
                inserir["ControladorTarefa"]();
            }
            else if (nomeControlador == "ControladorNota")
            {
                inserir["ControladorNota"]();
            }
            else if (nomeControlador == "ControladorCategoria")
                inserir["ControladorCategoria"]();
        }

        public Usuario ApresentarUsuario()
        {
            return Logged;
        }

        public void ArmazenarCofre(Cofre cofre)
        {
            this.cofre = cofre;
        }

        public bool ConferirCofre()
        {
            return cofre != null;
        }
    }
}
