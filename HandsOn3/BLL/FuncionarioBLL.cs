using DAL;
using System.Data;

namespace BLL
{
    public class FuncionarioBLL
    {
        public DataTable GetAllTabela()
        {
            return FuncionarioDAL.GetFuncionariosTabela();
        }

        public void Create(string nome, string nomeSetor)
        {
            FuncionarioDAL.Add(nome, nomeSetor);
        }

        public void Update(int setorId, string nome, string setor)
        {
            FuncionarioDAL.Update(setorId, nome, setor);
        }

        public void Delete(int setorId)
        {
            FuncionarioDAL.Delete(setorId);
        }
    }
}
