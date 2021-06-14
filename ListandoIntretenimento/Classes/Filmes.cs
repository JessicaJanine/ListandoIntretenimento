using System;

namespace ListandoIntretenimento
{
    public class Filmes : EntidadeBasica
    {
        private EnumGeneros Fgenero { get; set; }
        private string Ftitulo { get; set; }
        private string Fdescricao { get; set; }
        private int Fano { get; set; }
        private bool Fexcluido { get; set; }

        public Filmes (int fid, EnumGeneros fgenero, string ftitulo, string fdescricao, int fano)
        {
            this.Id = fid;
            this.Fgenero = fgenero;
            this.Ftitulo = ftitulo;
            this.Fdescricao = fdescricao;
            this.Fano = fano;
            this.Fexcluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Fgenero + Environment.NewLine;
            retorno += "Titulo: " + this.Ftitulo + Environment.NewLine;
            retorno += "Descrição: " + this.Fdescricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Fano + Environment.NewLine;
            retorno += "Excluido: " + this.Fexcluido;
            return retorno;
        }

        public string retornaFtitulo()
        {
            return this.Ftitulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaFexcluido()
        {
            return this.Fexcluido;
        }
        public void Fexcluir()
        {
            this.Fexcluido = true;
        }
    }
}