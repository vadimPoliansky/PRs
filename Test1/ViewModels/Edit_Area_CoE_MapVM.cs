using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndInv.Models.ViewModels
{
	public class Edit_Area_CoE_MapViewModel
	{
		public List<CoEs> allCoEs { get; set; }
		public List<Areas> allAreas { get; set; }
		public List<Area_CoE_Maps> allAreaCoEMaps { get; set; }

		public Int16 fiscalYear { get; set; }
	}
}