using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloCriptografar
{
    public class ServicoCriptografia
    {
        private readonly byte[] chave;

        public ServicoCriptografia(string chaveSecreta)
        {
            chave = SHA256.HashData(
                Encoding.UTF8.GetBytes(chaveSecreta)
            );
        }

        public string Criptografar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            byte[] nonce = RandomNumberGenerator.GetBytes(12);

            byte[] textoBytes = Encoding.UTF8.GetBytes(texto);
            byte[] textoCriptografado = new byte[textoBytes.Length];
            byte[] tag = new byte[16];

            using AesGcm aes = new AesGcm(chave, 16);

            aes.Encrypt(
                nonce,
                textoBytes,
                textoCriptografado,
                tag
            );

            byte[] resultado = new byte[
                nonce.Length +
                tag.Length +
                textoCriptografado.Length
            ];

            Buffer.BlockCopy(
                nonce, 0,
                resultado, 0,
                nonce.Length
            );

            Buffer.BlockCopy(
                tag, 0,
                resultado, nonce.Length,
                tag.Length
            );

            Buffer.BlockCopy(
                textoCriptografado, 0,
                resultado, nonce.Length + tag.Length,
                textoCriptografado.Length
            );

            return Convert.ToBase64String(resultado);
        }

        public string Descriptografar(string textoCriptografado)
        {
            if (string.IsNullOrEmpty(textoCriptografado))
                return textoCriptografado;

            byte[] dados = Convert.FromBase64String(textoCriptografado);

            byte[] nonce = dados[..12];
            byte[] tag = dados[12..28];
            byte[] conteudoCriptografado = dados[28..];

            byte[] textoOriginal = new byte[conteudoCriptografado.Length];

            using AesGcm aes = new AesGcm(chave, 16);

            aes.Decrypt(
                nonce,
                conteudoCriptografado,
                tag,
                textoOriginal
            );

            return Encoding.UTF8.GetString(textoOriginal);
        }
        public byte[] Criptografar(byte[] dados)
        {
            if (dados == null || dados.Length == 0)
                return dados;

            byte[] nonce = RandomNumberGenerator.GetBytes(12);

            byte[] dadosCriptografados = new byte[dados.Length];

            byte[] tag = new byte[16];

            using AesGcm aes = new AesGcm(chave, 16);

            aes.Encrypt(
                nonce,
                dados,
                dadosCriptografados,
                tag
            );

            byte[] resultado = new byte[
                nonce.Length +
                tag.Length +
                dadosCriptografados.Length
            ];

            Buffer.BlockCopy(
                nonce,
                0,
                resultado,
                0,
                nonce.Length
            );

            Buffer.BlockCopy(
                tag,
                0,
                resultado,
                nonce.Length,
                tag.Length
            );

            Buffer.BlockCopy(
                dadosCriptografados,
                0,
                resultado,
                nonce.Length + tag.Length,
                dadosCriptografados.Length
            );

            return resultado;
        }
        public byte[] Descriptografar(byte[] dadosCriptografados)
        {
            if (dadosCriptografados == null || dadosCriptografados.Length == 0)
                return dadosCriptografados;

            byte[] nonce = dadosCriptografados[..12];

            byte[] tag = dadosCriptografados[12..28];

            byte[] conteudoCriptografado = dadosCriptografados[28..];

            byte[] dadosOriginais =
                new byte[conteudoCriptografado.Length];

            using AesGcm aes = new AesGcm(chave, 16);

            aes.Decrypt(
                nonce,
                conteudoCriptografado,
                tag,
                dadosOriginais
            );

            return dadosOriginais;
        }
    }
}

