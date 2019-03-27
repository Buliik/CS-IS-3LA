using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Bul0056.Aggregates

{
    [DataObjectAttribute()]
    public class DTOManager
    {
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public static Collection <StrelbaDTO> GetDTOs()
        {
            Collection<Strelba> strelby = Strelba.SelectAll();
            Collection<StrelbaDTO> DT = new Collection<StrelbaDTO>();
            foreach (var str in strelby)
            {
                DT.Add(new StrelbaDTO(str));
            }

            return DT;
        }
    }
}
