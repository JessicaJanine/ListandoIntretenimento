using System;
using System.Collections.Generic;
using ListandoIntretenimento.Interfaces;

namespace ListandoIntretenimento
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}