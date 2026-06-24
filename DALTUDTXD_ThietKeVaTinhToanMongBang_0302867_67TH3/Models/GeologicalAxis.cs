using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTUDTXD_ThietKeVaTinhToanMongBang_0302867_67TH3.Models
{
    public class GeologicalAxis
    {
        public string Name { get; set; }
        public ObservableCollection<FoundationEntry> Entries { get; set; }

        public GeologicalAxis()
        {
            Entries = new ObservableCollection<FoundationEntry>();
        }
    }
}
