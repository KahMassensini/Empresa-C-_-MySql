using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa
{
    interface ICadForm
    {
        void bloquearCampos();

        void desbloquearCampos();

        void limparCampos();

        void atualizarGrid();

        void lerDados();
    }
}
