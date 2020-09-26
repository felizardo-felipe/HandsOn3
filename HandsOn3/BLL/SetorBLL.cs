using DAL;
using Model;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class SetorBLL
    {
        public DataTable GetAllTabela()
        {
            return SetorDAL.GetSetoresTabela();
        }

        public IEnumerable<Setor> GetAll()
        {
            return SetorDAL.GetSetores();
        }

        public void Create(string nome)
        {
            SetorDAL.Add(nome);
        }

        public void Update(int setorId, string nome)
        {
            SetorDAL.Update(setorId, nome);
        }

        public void Delete(int setorId)
        {
            SetorDAL.Delete(setorId);
        }
    }
}
