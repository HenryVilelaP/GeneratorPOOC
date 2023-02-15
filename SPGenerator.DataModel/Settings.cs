using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPGenerator.DataModel
{
    public class Settings
    {
        public string prefixWhereParameter = "@w";
        public string prefixInputParameter = "@p";
        public string prefixSelectSp = "spu_Listar_";
        public string prefixSearchSp = "spu_Buscar_";
        public string prefixInsertSp = "spu_Registrar_";
        public string prefixUpdateSp = "spu_Actualizar_";
        public string prefixDeleteSp = "spu_Eliminar_";
        public string  errorHandling = "Yes";
    }
}
