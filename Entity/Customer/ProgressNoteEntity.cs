using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ProgressNoteEntity
    {
        public Int32 progress_note_id { get; set; }
        public Int32 visit_id { get; set; }
        public Decimal t_c { get; set; }
        public Decimal p_min { get; set; }
        public Decimal r_min { get; set; }
        public Decimal bp_mmhg { get; set; }
        public Decimal o2sat_percent { get; set; }
        public Decimal bw_kg { get; set; }
        public Decimal ht_cm { get; set; }
        public Decimal bm_index { get; set; }
        public Int32 PageNumber { get; set; }
        public Int32 PageSize { get; set; }
        public string Description { get; set; }
    }
}
