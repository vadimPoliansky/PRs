using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IndInv.Helpers;

namespace IndInv.Models
{

	public class Indicators
	{

		[Key]
		public Int16 Indicator_ID { get; set; }
		public Int16 Area_ID { get; set; }
		public Int16? Analyst_ID { get; set; }
		public Int16? Format_ID { get; set; }
		[Display(Name = "Objectives/Metrics")]
		public string Indicator { get; set; }
		[Display(Name = "Indicator Type")]
		public string Indicator_Type { get; set; }

		public string Identifier { get; set; }

		public bool? Indicator_N_Value { get; set; }
		public Int16? Indicator_N_Value_ID { get; set; }

		[Display(Name = "FY 10/11")]
		public string FY_10_11_YTD { get; set; }
		public string FY_10_11_YTD_Sup { get; set; }
		[Display(Name = "FY 11/12")]
		public string FY_11_12_YTD { get; set; }
		public string FY_11_12_YTD_Sup { get; set; }
		[Display(Name = "FY 12/13")]
		public string FY_12_13_YTD { get; set; }
		public string FY_12_13_YTD_Sup { get; set; }

		[Display(Name = "Q1")]
		public string FY_13_14_Q1 { get; set; }
		public string FY_13_14_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_13_14_Q2 { get; set; }
		public string FY_13_14_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_13_14_Q3 { get; set; }
		public string FY_13_14_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_13_14_Q4 { get; set; }
		public string FY_13_14_Q4_Sup { get; set; }
		[Display(Name = "FY 13/14")]
		public string FY_13_14_YTD { get; set; }
		public string FY_13_14_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_13_14_Target { get; set; }
		public string FY_13_14_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_13_14_Comparator { get; set; }
		public string FY_13_14_Comparator_Sup { get; set; }
		public string FY_13_14_Comparator_Q1 { get; set; }
		public string FY_13_14_Comparator_Q2 { get; set; }
		public string FY_13_14_Comparator_Q3 { get; set; }
		public string FY_13_14_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//        public string FY_13_14_Performance_Threshold { get; set; }
		public virtual string FY_13_14_Performance_Threshold { get { return Color.getThreshold(FY_13_14_Target, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID, 2); } }
		public string FY_13_14_Performance_Threshold_Sup { get; set; }
		public Int16 FY_13_14_Color_ID { get; set; }
		public Int16 FY_13_14_Threshold_ID { get; set; }
		public Int16 FY_13_14_Direction_ID { get; set; }
		public string FY_13_14_YTD_Custom_Color { get; set; }
		public string FY_13_14_Q1_Custom_Color { get; set; }
		public string FY_13_14_Q2_Custom_Color { get; set; }
		public string FY_13_14_Q3_Custom_Color { get; set; }
		public string FY_13_14_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_13_14_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_13_14_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_13_14_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_13_14_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_13_14_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_13_14_OPEO_Lead { get; set; }

		public virtual string FY_13_14_Q1_Color { get { return Color.getColor(FY_13_14_Q1, FY_13_14_Target, FY_13_14_Q1_Sup, FY_13_14_Q1_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID, 1); } }
		public virtual string FY_13_14_Q2_Color { get { return Color.getColor(FY_13_14_Q2, FY_13_14_Target, FY_13_14_Q2_Sup, FY_13_14_Q2_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID, 1); } }
		public virtual string FY_13_14_Q3_Color { get { return Color.getColor(FY_13_14_Q3, FY_13_14_Target, FY_13_14_Q3_Sup, FY_13_14_Q3_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID, 1); } }
		public virtual string FY_13_14_Q4_Color { get { return Color.getColor(FY_13_14_Q4, FY_13_14_Target, FY_13_14_Q4_Sup, FY_13_14_Q4_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID, 1); } }
		public virtual string FY_13_14_YTD_Color { get { return Color.getColor(FY_13_14_YTD, FY_13_14_Target, FY_13_14_YTD, FY_13_14_YTD_Custom_Color, FY_13_14_Color_ID, true, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID, 1); } }



		[Display(Name = "Q1")]
		public string FY_14_15_Q1 { get; set; }
		public string FY_14_15_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_14_15_Q2 { get; set; }
		public string FY_14_15_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_14_15_Q3 { get; set; }
		public string FY_14_15_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_14_15_Q4 { get; set; }
		public string FY_14_15_Q4_Sup { get; set; }
		[Display(Name = "FY 14/15")]
		public string FY_14_15_YTD { get; set; }
		public string FY_14_15_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_14_15_Target { get; set; }
		public string FY_14_15_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_14_15_Comparator { get; set; }
		public string FY_14_15_Comparator_Sup { get; set; }
		public string FY_14_15_Comparator_Q1 { get; set; }
		public string FY_14_15_Comparator_Q2 { get; set; }
		public string FY_14_15_Comparator_Q3 { get; set; }
		public string FY_14_15_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//public string FY_14_15_Performance_Threshold { get; set; }
		public string FY_14_15_Performance_Threshold_Sup { get; set; }
		public Int16 FY_14_15_Color_ID { get; set; }
		public Int16 FY_14_15_Threshold_ID { get; set; }
		public virtual string FY_14_15_Performance_Threshold { get { return Color.getThreshold(FY_14_15_Target, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID, 2); } }
		public Int16 FY_14_15_Direction_ID { get; set; }
		public string FY_14_15_YTD_Custom_Color { get; set; }
		public string FY_14_15_Q1_Custom_Color { get; set; }
		public string FY_14_15_Q2_Custom_Color { get; set; }
		public string FY_14_15_Q3_Custom_Color { get; set; }
		public string FY_14_15_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_14_15_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_14_15_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_14_15_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_14_15_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_14_15_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_14_15_OPEO_Lead { get; set; }

		public virtual string FY_14_15_Q1_Color { get { return Color.getColor(FY_14_15_Q1, FY_14_15_Target, FY_14_15_Q1_Sup, FY_14_15_Q1_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID, 2); } }
		public virtual string FY_14_15_Q2_Color { get { return Color.getColor(FY_14_15_Q2, FY_14_15_Target, FY_14_15_Q2_Sup, FY_14_15_Q2_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID, 2); } }
		public virtual string FY_14_15_Q3_Color { get { return Color.getColor(FY_14_15_Q3, FY_14_15_Target, FY_14_15_Q3_Sup, FY_14_15_Q3_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID, 2); } }
		public virtual string FY_14_15_Q4_Color { get { return Color.getColor(FY_14_15_Q4, FY_14_15_Target, FY_14_15_Q4_Sup, FY_14_15_Q4_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID, 2); } }
		public virtual string FY_14_15_YTD_Color { get { return Color.getColor(FY_14_15_YTD, FY_14_15_Target, FY_14_15_YTD, FY_14_15_YTD_Custom_Color, FY_14_15_Color_ID, true, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID, 2); } }


		[Display(Name = "Q1")]
		public string FY_15_16_Q1 { get; set; }
		public string FY_15_16_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_15_16_Q2 { get; set; }
		public string FY_15_16_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_15_16_Q3 { get; set; }
		public string FY_15_16_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_15_16_Q4 { get; set; }
		public string FY_15_16_Q4_Sup { get; set; }
		[Display(Name = "FY 15/16")]
		public string FY_15_16_YTD { get; set; }
		public string FY_15_16_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_15_16_Target { get; set; }
		public string FY_15_16_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_15_16_Comparator { get; set; }
		public string FY_15_16_Comparator_Sup { get; set; }
		public string FY_15_16_Comparator_Q1 { get; set; }
		public string FY_15_16_Comparator_Q2 { get; set; }
		public string FY_15_16_Comparator_Q3 { get; set; }
		public string FY_15_16_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_15_16_Performance_Threshold { get; set; }
		public virtual string FY_15_16_Performance_Threshold { get { return Color.getThreshold(FY_15_16_Target, this, FY_15_16_Threshold_ID, FY_15_16_Direction_ID, 2); } }
		public string FY_15_16_Performance_Threshold_Sup { get; set; }
		public Int16 FY_15_16_Color_ID { get; set; }
		public Int16 FY_15_16_Threshold_ID { get; set; }
		public Int16 FY_15_16_Direction_ID { get; set; }
		public string FY_15_16_YTD_Custom_Color { get; set; }
		public string FY_15_16_Q1_Custom_Color { get; set; }
		public string FY_15_16_Q2_Custom_Color { get; set; }
		public string FY_15_16_Q3_Custom_Color { get; set; }
		public string FY_15_16_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_15_16_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_15_16_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_15_16_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_15_16_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_15_16_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_15_16_OPEO_Lead { get; set; }

		public virtual string FY_15_16_Q1_Color { get { return Color.getColor(FY_15_16_Q1, FY_15_16_Target, FY_15_16_Q1_Sup, FY_15_16_Q1_Custom_Color, FY_15_16_Color_ID, false, this, FY_15_16_Threshold_ID, FY_15_16_Direction_ID, 3); } }
		public virtual string FY_15_16_Q2_Color { get { return Color.getColor(FY_15_16_Q2, FY_15_16_Target, FY_15_16_Q2_Sup, FY_15_16_Q2_Custom_Color, FY_15_16_Color_ID, false, this, FY_15_16_Threshold_ID, FY_15_16_Direction_ID, 3); } }
		public virtual string FY_15_16_Q3_Color { get { return Color.getColor(FY_15_16_Q3, FY_15_16_Target, FY_15_16_Q3_Sup, FY_15_16_Q3_Custom_Color, FY_15_16_Color_ID, false, this, FY_15_16_Threshold_ID, FY_15_16_Direction_ID, 3); } }
		public virtual string FY_15_16_Q4_Color { get { return Color.getColor(FY_15_16_Q4, FY_15_16_Target, FY_15_16_Q4_Sup, FY_15_16_Q4_Custom_Color, FY_15_16_Color_ID, false, this, FY_15_16_Threshold_ID, FY_15_16_Direction_ID, 3); } }
		public virtual string FY_15_16_YTD_Color { get { return Color.getColor(FY_15_16_YTD, FY_15_16_Target, FY_15_16_YTD, FY_15_16_YTD_Custom_Color, FY_15_16_Color_ID, true, this, FY_15_16_Threshold_ID, FY_15_16_Direction_ID, 3); } }

		[Display(Name = "Q1")]
		public string FY_16_17_Q1 { get; set; }
		public string FY_16_17_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_16_17_Q2 { get; set; }
		public string FY_16_17_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_16_17_Q3 { get; set; }
		public string FY_16_17_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_16_17_Q4 { get; set; }
		public string FY_16_17_Q4_Sup { get; set; }
		[Display(Name = "FY 16/17")]
		public string FY_16_17_YTD { get; set; }
		public string FY_16_17_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_16_17_Target { get; set; }
		public string FY_16_17_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_16_17_Comparator { get; set; }
		public string FY_16_17_Comparator_Sup { get; set; }
		public string FY_16_17_Comparator_Q1 { get; set; }
		public string FY_16_17_Comparator_Q2 { get; set; }
		public string FY_16_17_Comparator_Q3 { get; set; }
		public string FY_16_17_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_16_17_Performance_Threshold { get; set; }
		public virtual string FY_16_17_Performance_Threshold { get { return Color.getThreshold(FY_16_17_Target, this, FY_16_17_Threshold_ID, FY_16_17_Direction_ID, 2); } }
		public string FY_16_17_Performance_Threshold_Sup { get; set; }
		public Int16 FY_16_17_Color_ID { get; set; }
		public Int16 FY_16_17_Threshold_ID { get; set; }
		public Int16 FY_16_17_Direction_ID { get; set; }
		public string FY_16_17_YTD_Custom_Color { get; set; }
		public string FY_16_17_Q1_Custom_Color { get; set; }
		public string FY_16_17_Q2_Custom_Color { get; set; }
		public string FY_16_17_Q3_Custom_Color { get; set; }
		public string FY_16_17_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_16_17_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_16_17_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_16_17_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_16_17_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_16_17_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_16_17_OPEO_Lead { get; set; }

		public virtual string FY_16_17_Q1_Color { get { return Color.getColor(FY_16_17_Q1, FY_16_17_Target, FY_13_14_Q1_Sup, FY_16_17_Q1_Custom_Color, FY_16_17_Color_ID, false, this, FY_16_17_Threshold_ID, FY_16_17_Direction_ID, 3); } }
		public virtual string FY_16_17_Q2_Color { get { return Color.getColor(FY_16_17_Q2, FY_16_17_Target, FY_13_14_Q2_Sup, FY_16_17_Q2_Custom_Color, FY_16_17_Color_ID, false, this, FY_16_17_Threshold_ID, FY_16_17_Direction_ID, 3); } }
		public virtual string FY_16_17_Q3_Color { get { return Color.getColor(FY_16_17_Q3, FY_16_17_Target, FY_13_14_Q3_Sup, FY_16_17_Q3_Custom_Color, FY_16_17_Color_ID, false, this, FY_16_17_Threshold_ID, FY_16_17_Direction_ID, 3); } }
		public virtual string FY_16_17_Q4_Color { get { return Color.getColor(FY_16_17_Q4, FY_16_17_Target, FY_13_14_Q4_Sup, FY_16_17_Q4_Custom_Color, FY_16_17_Color_ID, false, this, FY_16_17_Threshold_ID, FY_16_17_Direction_ID, 3); } }
		public virtual string FY_16_17_YTD_Color { get { return Color.getColor(FY_16_17_YTD, FY_16_17_Target, FY_13_14_YTD, FY_16_17_YTD_Custom_Color, FY_16_17_Color_ID, true, this, FY_16_17_Threshold_ID, FY_16_17_Direction_ID, 3); } }

		[Display(Name = "Q1")]
		public string FY_17_18_Q1 { get; set; }
		public string FY_17_18_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_17_18_Q2 { get; set; }
		public string FY_17_18_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_17_18_Q3 { get; set; }
		public string FY_17_18_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_17_18_Q4 { get; set; }
		public string FY_17_18_Q4_Sup { get; set; }
		[Display(Name = "FY 17/18")]
		public string FY_17_18_YTD { get; set; }
		public string FY_17_18_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_17_18_Target { get; set; }
		public string FY_17_18_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_17_18_Comparator { get; set; }
		public string FY_17_18_Comparator_Sup { get; set; }
		public string FY_17_18_Comparator_Q1 { get; set; }
		public string FY_17_18_Comparator_Q2 { get; set; }
		public string FY_17_18_Comparator_Q3 { get; set; }
		public string FY_17_18_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_17_18_Performance_Threshold { get; set; }
		public virtual string FY_17_18_Performance_Threshold { get { return Color.getThreshold(FY_17_18_Target, this, FY_17_18_Threshold_ID, FY_17_18_Direction_ID, 2); } }
		public string FY_17_18_Performance_Threshold_Sup { get; set; }
		public Int16 FY_17_18_Color_ID { get; set; }
		public Int16 FY_17_18_Threshold_ID { get; set; }
		public Int16 FY_17_18_Direction_ID { get; set; }
		public string FY_17_18_YTD_Custom_Color { get; set; }
		public string FY_17_18_Q1_Custom_Color { get; set; }
		public string FY_17_18_Q2_Custom_Color { get; set; }
		public string FY_17_18_Q3_Custom_Color { get; set; }
		public string FY_17_18_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_17_18_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_17_18_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_17_18_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_17_18_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_17_18_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_17_18_OPEO_Lead { get; set; }

		public virtual string FY_17_18_Q1_Color { get { return Color.getColor(FY_17_18_Q1, FY_17_18_Target, FY_13_14_Q1_Sup, FY_17_18_Q1_Custom_Color, FY_17_18_Color_ID, false, this, FY_17_18_Threshold_ID, FY_17_18_Direction_ID, 3); } }
		public virtual string FY_17_18_Q2_Color { get { return Color.getColor(FY_17_18_Q2, FY_17_18_Target, FY_13_14_Q2_Sup, FY_17_18_Q2_Custom_Color, FY_17_18_Color_ID, false, this, FY_17_18_Threshold_ID, FY_17_18_Direction_ID, 3); } }
		public virtual string FY_17_18_Q3_Color { get { return Color.getColor(FY_17_18_Q3, FY_17_18_Target, FY_13_14_Q3_Sup, FY_17_18_Q3_Custom_Color, FY_17_18_Color_ID, false, this, FY_17_18_Threshold_ID, FY_17_18_Direction_ID, 3); } }
		public virtual string FY_17_18_Q4_Color { get { return Color.getColor(FY_17_18_Q4, FY_17_18_Target, FY_13_14_Q4_Sup, FY_17_18_Q4_Custom_Color, FY_17_18_Color_ID, false, this, FY_17_18_Threshold_ID, FY_17_18_Direction_ID, 3); } }
		public virtual string FY_17_18_YTD_Color { get { return Color.getColor(FY_17_18_YTD, FY_17_18_Target, FY_13_14_YTD, FY_17_18_YTD_Custom_Color, FY_17_18_Color_ID, true, this, FY_17_18_Threshold_ID, FY_17_18_Direction_ID, 3); } }

		[Display(Name = "Q1")]
		public string FY_18_19_Q1 { get; set; }
		public string FY_18_19_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_18_19_Q2 { get; set; }
		public string FY_18_19_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_18_19_Q3 { get; set; }
		public string FY_18_19_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_18_19_Q4 { get; set; }
		public string FY_18_19_Q4_Sup { get; set; }
		[Display(Name = "FY 18/19")]
		public string FY_18_19_YTD { get; set; }
		public string FY_18_19_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_18_19_Target { get; set; }
		public string FY_18_19_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_18_19_Comparator { get; set; }
		public string FY_18_19_Comparator_Sup { get; set; }
		public string FY_18_19_Comparator_Q1 { get; set; }
		public string FY_18_19_Comparator_Q2 { get; set; }
		public string FY_18_19_Comparator_Q3 { get; set; }
		public string FY_18_19_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_18_19_Performance_Threshold { get; set; }
		public virtual string FY_18_19_Performance_Threshold { get { return Color.getThreshold(FY_18_19_Target, this, FY_18_19_Threshold_ID, FY_18_19_Direction_ID, 2); } }
		public string FY_18_19_Performance_Threshold_Sup { get; set; }
		public Int16 FY_18_19_Color_ID { get; set; }
		public Int16 FY_18_19_Threshold_ID { get; set; }
		public Int16 FY_18_19_Direction_ID { get; set; }
		public string FY_18_19_YTD_Custom_Color { get; set; }
		public string FY_18_19_Q1_Custom_Color { get; set; }
		public string FY_18_19_Q2_Custom_Color { get; set; }
		public string FY_18_19_Q3_Custom_Color { get; set; }
		public string FY_18_19_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_18_19_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_18_19_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_18_19_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_18_19_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_18_19_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_18_19_OPEO_Lead { get; set; }

		public virtual string FY_18_19_Q1_Color { get { return Color.getColor(FY_18_19_Q1, FY_18_19_Target, FY_13_14_Q1_Sup, FY_18_19_Q1_Custom_Color, FY_18_19_Color_ID, false, this, FY_18_19_Threshold_ID, FY_18_19_Direction_ID, 3); } }
		public virtual string FY_18_19_Q2_Color { get { return Color.getColor(FY_18_19_Q2, FY_18_19_Target, FY_13_14_Q2_Sup, FY_18_19_Q2_Custom_Color, FY_18_19_Color_ID, false, this, FY_18_19_Threshold_ID, FY_18_19_Direction_ID, 3); } }
		public virtual string FY_18_19_Q3_Color { get { return Color.getColor(FY_18_19_Q3, FY_18_19_Target, FY_13_14_Q3_Sup, FY_18_19_Q3_Custom_Color, FY_18_19_Color_ID, false, this, FY_18_19_Threshold_ID, FY_18_19_Direction_ID, 3); } }
		public virtual string FY_18_19_Q4_Color { get { return Color.getColor(FY_18_19_Q4, FY_18_19_Target, FY_13_14_Q4_Sup, FY_18_19_Q4_Custom_Color, FY_18_19_Color_ID, false, this, FY_18_19_Threshold_ID, FY_18_19_Direction_ID, 3); } }
		public virtual string FY_18_19_YTD_Color { get { return Color.getColor(FY_18_19_YTD, FY_18_19_Target, FY_13_14_YTD, FY_18_19_YTD_Custom_Color, FY_18_19_Color_ID, true, this, FY_18_19_Threshold_ID, FY_18_19_Direction_ID, 3); } }

		[Display(Name = "Q1")]
		public string FY_19_20_Q1 { get; set; }
		public string FY_19_20_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_19_20_Q2 { get; set; }
		public string FY_19_20_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_19_20_Q3 { get; set; }
		public string FY_19_20_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_19_20_Q4 { get; set; }
		public string FY_19_20_Q4_Sup { get; set; }
		[Display(Name = "FY 19/20")]
		public string FY_19_20_YTD { get; set; }
		public string FY_19_20_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_19_20_Target { get; set; }
		public string FY_19_20_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_19_20_Comparator { get; set; }
		public string FY_19_20_Comparator_Sup { get; set; }
		public string FY_19_20_Comparator_Q1 { get; set; }
		public string FY_19_20_Comparator_Q2 { get; set; }
		public string FY_19_20_Comparator_Q3 { get; set; }
		public string FY_19_20_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_19_20_Performance_Threshold { get; set; }
		public virtual string FY_19_20_Performance_Threshold { get { return Color.getThreshold(FY_19_20_Target, this, FY_19_20_Threshold_ID, FY_19_20_Direction_ID, 2); } }
		public string FY_19_20_Performance_Threshold_Sup { get; set; }
		public Int16 FY_19_20_Color_ID { get; set; }
		public Int16 FY_19_20_Threshold_ID { get; set; }
		public Int16 FY_19_20_Direction_ID { get; set; }
		public string FY_19_20_YTD_Custom_Color { get; set; }
		public string FY_19_20_Q1_Custom_Color { get; set; }
		public string FY_19_20_Q2_Custom_Color { get; set; }
		public string FY_19_20_Q3_Custom_Color { get; set; }
		public string FY_19_20_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_19_20_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_19_20_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_19_20_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_19_20_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_19_20_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_19_20_OPEO_Lead { get; set; }

		public virtual string FY_19_20_Q1_Color { get { return Color.getColor(FY_19_20_Q1, FY_19_20_Target, FY_13_14_Q1_Sup, FY_19_20_Q1_Custom_Color, FY_19_20_Color_ID, false, this, FY_19_20_Threshold_ID, FY_19_20_Direction_ID, 3); } }
		public virtual string FY_19_20_Q2_Color { get { return Color.getColor(FY_19_20_Q2, FY_19_20_Target, FY_13_14_Q2_Sup, FY_19_20_Q2_Custom_Color, FY_19_20_Color_ID, false, this, FY_19_20_Threshold_ID, FY_19_20_Direction_ID, 3); } }
		public virtual string FY_19_20_Q3_Color { get { return Color.getColor(FY_19_20_Q3, FY_19_20_Target, FY_13_14_Q3_Sup, FY_19_20_Q3_Custom_Color, FY_19_20_Color_ID, false, this, FY_19_20_Threshold_ID, FY_19_20_Direction_ID, 3); } }
		public virtual string FY_19_20_Q4_Color { get { return Color.getColor(FY_19_20_Q4, FY_19_20_Target, FY_13_14_Q4_Sup, FY_19_20_Q4_Custom_Color, FY_19_20_Color_ID, false, this, FY_19_20_Threshold_ID, FY_19_20_Direction_ID, 3); } }
		public virtual string FY_19_20_YTD_Color { get { return Color.getColor(FY_19_20_YTD, FY_19_20_Target, FY_13_14_YTD, FY_19_20_YTD_Custom_Color, FY_19_20_Color_ID, true, this, FY_19_20_Threshold_ID, FY_19_20_Direction_ID, 3); } }

		[Display(Name = "Q1")]
		public string FY_20_21_Q1 { get; set; }
		public string FY_20_21_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_20_21_Q2 { get; set; }
		public string FY_20_21_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_20_21_Q3 { get; set; }
		public string FY_20_21_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_20_21_Q4 { get; set; }
		public string FY_20_21_Q4_Sup { get; set; }
		[Display(Name = "FY 20/21")]
		public string FY_20_21_YTD { get; set; }
		public string FY_20_21_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_20_21_Target { get; set; }
		public string FY_20_21_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_20_21_Comparator { get; set; }
		public string FY_20_21_Comparator_Sup { get; set; }
		public string FY_20_21_Comparator_Q1 { get; set; }
		public string FY_20_21_Comparator_Q2 { get; set; }
		public string FY_20_21_Comparator_Q3 { get; set; }
		public string FY_20_21_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_20_21_Performance_Threshold { get; set; }
		public virtual string FY_20_21_Performance_Threshold { get { return Color.getThreshold(FY_20_21_Target, this, FY_20_21_Threshold_ID, FY_20_21_Direction_ID, 2); } }
		public string FY_20_21_Performance_Threshold_Sup { get; set; }
		public Int16 FY_20_21_Color_ID { get; set; }
		public Int16 FY_20_21_Threshold_ID { get; set; }
		public Int16 FY_20_21_Direction_ID { get; set; }
		public string FY_20_21_YTD_Custom_Color { get; set; }
		public string FY_20_21_Q1_Custom_Color { get; set; }
		public string FY_20_21_Q2_Custom_Color { get; set; }
		public string FY_20_21_Q3_Custom_Color { get; set; }
		public string FY_20_21_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_20_21_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_20_21_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_20_21_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_20_21_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_20_21_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_20_21_OPEO_Lead { get; set; }

		public virtual string FY_20_21_Q1_Color { get { return Color.getColor(FY_20_21_Q1, FY_20_21_Target, FY_13_14_Q1_Sup, FY_20_21_Q1_Custom_Color, FY_20_21_Color_ID, false, this, FY_20_21_Threshold_ID, FY_20_21_Direction_ID, 3); } }
		public virtual string FY_20_21_Q2_Color { get { return Color.getColor(FY_20_21_Q2, FY_20_21_Target, FY_13_14_Q2_Sup, FY_20_21_Q2_Custom_Color, FY_20_21_Color_ID, false, this, FY_20_21_Threshold_ID, FY_20_21_Direction_ID, 3); } }
		public virtual string FY_20_21_Q3_Color { get { return Color.getColor(FY_20_21_Q3, FY_20_21_Target, FY_13_14_Q3_Sup, FY_20_21_Q3_Custom_Color, FY_20_21_Color_ID, false, this, FY_20_21_Threshold_ID, FY_20_21_Direction_ID, 3); } }
		public virtual string FY_20_21_Q4_Color { get { return Color.getColor(FY_20_21_Q4, FY_20_21_Target, FY_13_14_Q4_Sup, FY_20_21_Q4_Custom_Color, FY_20_21_Color_ID, false, this, FY_20_21_Threshold_ID, FY_20_21_Direction_ID, 3); } }
		public virtual string FY_20_21_YTD_Color { get { return Color.getColor(FY_20_21_YTD, FY_20_21_Target, FY_13_14_YTD, FY_20_21_YTD_Custom_Color, FY_20_21_Color_ID, true, this, FY_20_21_Threshold_ID, FY_20_21_Direction_ID, 3); } }

		[Display(Name = "Q1")]
		public string FY_21_22_Q1 { get; set; }
		public string FY_21_22_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_21_22_Q2 { get; set; }
		public string FY_21_22_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_21_22_Q3 { get; set; }
		public string FY_21_22_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_21_22_Q4 { get; set; }
		public string FY_21_22_Q4_Sup { get; set; }
		[Display(Name = "FY 21/22")]
		public string FY_21_22_YTD { get; set; }
		public string FY_21_22_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_21_22_Target { get; set; }
		public string FY_21_22_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_21_22_Comparator { get; set; }
		public string FY_21_22_Comparator_Sup { get; set; }
		public string FY_21_22_Comparator_Q1 { get; set; }
		public string FY_21_22_Comparator_Q2 { get; set; }
		public string FY_21_22_Comparator_Q3 { get; set; }
		public string FY_21_22_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_21_22_Performance_Threshold { get; set; }
		public virtual string FY_21_22_Performance_Threshold { get { return Color.getThreshold(FY_21_22_Target, this, FY_21_22_Threshold_ID, FY_21_22_Direction_ID, 2); } }
		public string FY_21_22_Performance_Threshold_Sup { get; set; }
		public Int16 FY_21_22_Color_ID { get; set; }
		public Int16 FY_21_22_Threshold_ID { get; set; }
		public Int16 FY_21_22_Direction_ID { get; set; }
		public string FY_21_22_YTD_Custom_Color { get; set; }
		public string FY_21_22_Q1_Custom_Color { get; set; }
		public string FY_21_22_Q2_Custom_Color { get; set; }
		public string FY_21_22_Q3_Custom_Color { get; set; }
		public string FY_21_22_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_21_22_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_21_22_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_21_22_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_21_22_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_21_22_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_21_22_OPEO_Lead { get; set; }

		public virtual string FY_21_22_Q1_Color { get { return Color.getColor(FY_21_22_Q1, FY_21_22_Target, FY_13_14_Q1_Sup, FY_21_22_Q1_Custom_Color, FY_21_22_Color_ID, false, this, FY_21_22_Threshold_ID, FY_21_22_Direction_ID, 3); } }
		public virtual string FY_21_22_Q2_Color { get { return Color.getColor(FY_21_22_Q2, FY_21_22_Target, FY_13_14_Q2_Sup, FY_21_22_Q2_Custom_Color, FY_21_22_Color_ID, false, this, FY_21_22_Threshold_ID, FY_21_22_Direction_ID, 3); } }
		public virtual string FY_21_22_Q3_Color { get { return Color.getColor(FY_21_22_Q3, FY_21_22_Target, FY_13_14_Q3_Sup, FY_21_22_Q3_Custom_Color, FY_21_22_Color_ID, false, this, FY_21_22_Threshold_ID, FY_21_22_Direction_ID, 3); } }
		public virtual string FY_21_22_Q4_Color { get { return Color.getColor(FY_21_22_Q4, FY_21_22_Target, FY_13_14_Q4_Sup, FY_21_22_Q4_Custom_Color, FY_21_22_Color_ID, false, this, FY_21_22_Threshold_ID, FY_21_22_Direction_ID, 3); } }
		public virtual string FY_21_22_YTD_Color { get { return Color.getColor(FY_21_22_YTD, FY_21_22_Target, FY_13_14_YTD, FY_21_22_YTD_Custom_Color, FY_21_22_Color_ID, true, this, FY_21_22_Threshold_ID, FY_21_22_Direction_ID, 3); } }

		[Display(Name = "Q1")]
		public string FY_22_23_Q1 { get; set; }
		public string FY_22_23_Q1_Sup { get; set; }
		[Display(Name = "Q2")]
		public string FY_22_23_Q2 { get; set; }
		public string FY_22_23_Q2_Sup { get; set; }
		[Display(Name = "Q3")]
		public string FY_22_23_Q3 { get; set; }
		public string FY_22_23_Q3_Sup { get; set; }
		[Display(Name = "Q4")]
		public string FY_22_23_Q4 { get; set; }
		public string FY_22_23_Q4_Sup { get; set; }
		[Display(Name = "FY 22/23")]
		public string FY_22_23_YTD { get; set; }
		public string FY_22_23_YTD_Sup { get; set; }
		[Display(Name = "Target")]
		public string FY_22_23_Target { get; set; }
		public string FY_22_23_Target_Sup { get; set; }
		[Display(Name = "Comparator")]
		public string FY_22_23_Comparator { get; set; }
		public string FY_22_23_Comparator_Sup { get; set; }
		public string FY_22_23_Comparator_Q1 { get; set; }
		public string FY_22_23_Comparator_Q2 { get; set; }
		public string FY_22_23_Comparator_Q3 { get; set; }
		public string FY_22_23_Comparator_Q4 { get; set; }
		[Display(Name = "Performance Threshold")]
		//		public string FY_22_23_Performance_Threshold { get; set; }
		public virtual string FY_22_23_Performance_Threshold { get { return Color.getThreshold(FY_22_23_Target, this, FY_22_23_Threshold_ID, FY_22_23_Direction_ID, 2); } }
		public string FY_22_23_Performance_Threshold_Sup { get; set; }
		public Int16 FY_22_23_Color_ID { get; set; }
		public Int16 FY_22_23_Threshold_ID { get; set; }
		public Int16 FY_22_23_Direction_ID { get; set; }
		public string FY_22_23_YTD_Custom_Color { get; set; }
		public string FY_22_23_Q1_Custom_Color { get; set; }
		public string FY_22_23_Q2_Custom_Color { get; set; }
		public string FY_22_23_Q3_Custom_Color { get; set; }
		public string FY_22_23_Q4_Custom_Color { get; set; }
		[Display(Name = "Definition/Calculation/Notes")]
		public string FY_22_23_Definition_Calculation { get; set; }
		[Display(Name = "Target Rationale")]
		public string FY_22_23_Target_Rationale { get; set; }
		[Display(Name = "Comparator Source")]
		public string FY_22_23_Comparator_Source { get; set; }
		[Display(Name = "Data Source MSH")]
		public string FY_22_23_Data_Source_MSH { get; set; }
		[Display(Name = "Data Source Benchmark")]
		public string FY_22_23_Data_Source_Benchmark { get; set; }
		[Display(Name = "OPEO Lead")]
		public string FY_22_23_OPEO_Lead { get; set; }

		[Display(Name = "Comments")]
		public string Comment { get; set; }

		public virtual string FY_22_23_Q1_Color { get { return Color.getColor(FY_22_23_Q1, FY_22_23_Target, FY_13_14_Q1_Sup, FY_22_23_Q1_Custom_Color, FY_22_23_Color_ID, false, this, FY_22_23_Threshold_ID, FY_22_23_Direction_ID, 3); } }
		public virtual string FY_22_23_Q2_Color { get { return Color.getColor(FY_22_23_Q2, FY_22_23_Target, FY_13_14_Q2_Sup, FY_22_23_Q2_Custom_Color, FY_22_23_Color_ID, false, this, FY_22_23_Threshold_ID, FY_22_23_Direction_ID, 3); } }
		public virtual string FY_22_23_Q3_Color { get { return Color.getColor(FY_22_23_Q3, FY_22_23_Target, FY_13_14_Q3_Sup, FY_22_23_Q3_Custom_Color, FY_22_23_Color_ID, false, this, FY_22_23_Threshold_ID, FY_22_23_Direction_ID, 3); } }
		public virtual string FY_22_23_Q4_Color { get { return Color.getColor(FY_22_23_Q4, FY_22_23_Target, FY_13_14_Q4_Sup, FY_22_23_Q4_Custom_Color, FY_22_23_Color_ID, false, this, FY_22_23_Threshold_ID, FY_22_23_Direction_ID, 3); } }
		public virtual string FY_22_23_YTD_Color { get { return Color.getColor(FY_22_23_YTD, FY_22_23_Target, FY_13_14_YTD, FY_22_23_YTD_Custom_Color, FY_22_23_Color_ID, true, this, FY_22_23_Threshold_ID, FY_22_23_Direction_ID, 3); } }

		public Int16? Indicator_Link { get; set; }

		public virtual ICollection<Indicator_CoE_Maps> Indicator_CoE_Map { get; set; }
		public virtual Areas Area { get; set; }
		public virtual ICollection<Indicator_Footnote_Maps> Indicator_Footnote_Map { get; set; }
		public virtual Formats Format { get; set; }
	}

	public class CoEs
	{
		[Key]
		public Int16 CoE_ID { get; set; }
		public string CoE { get; set; }
		public string CoE_Abbr { get; set; }
		public string CoE_Type { get; set; }
		public string CoE_Notes { get; set; }
		public string CoE_Subtitle { get; set; }
		public string CoE_Title { get; set; }

		public bool? FY_14_15_Draft { get; set; }
		public bool? FY_15_16_Draft { get; set; }
		public bool? FY_16_17_Draft { get; set; }
		public bool? FY_17_18_Draft { get; set; }
		public bool? FY_18_19_Draft { get; set; }
		public bool? FY_19_20_Draft { get; set; }
		public bool? FY_20_21_Draft { get; set; }
		public bool? FY_21_22_Draft { get; set; }
		public bool? FY_22_23_Draft { get; set; }


		public virtual ICollection<Indicator_CoE_Maps> Indicator_CoE_Map { get; set; }
		public virtual ICollection<Area_CoE_Maps> Area_CoE_Map { get; set; }

		public virtual ICollection<Link_CoE_Maps> Link_CoE_Maps { get; set; }
	}

	public class Link_CoEs
	{
		[Key]
		public Int16 Link_CoE_ID { get; set; }
		public string CoE { get; set; }
		public string CoE_Abbr { get; set; }
		public string CoE_Type { get; set; }
		public string CoE_Notes { get; set; }
		public string CoE_Subtitle { get; set; }
		public string CoE_Title { get; set; }

		public bool? FY_14_15_Draft { get; set; }
		public bool? FY_15_16_Draft { get; set; }
		public bool? FY_16_17_Draft { get; set; }
		public bool? FY_17_18_Draft { get; set; }
		public bool? FY_18_19_Draft { get; set; }
		public bool? FY_19_20_Draft { get; set; }
		public bool? FY_20_21_Draft { get; set; }
		public bool? FY_21_22_Draft { get; set; }
		public bool? FY_22_23_Draft { get; set; }

		public virtual ICollection<Link_CoE_Maps> Link_CoE_Maps { get; set; }
	}

	public class Link_CoE_Maps
	{
		[Key]
		public Int16 Link_CoE_Map_ID { get; set; }
		public Int16 Link_CoE_ID { get; set; }
		public Int16 CoE_ID { get; set; }
	}

	public class Indicator_Links
	{
		[Key]
		public Int16 Link_ID { get; set; }

		public virtual ICollection<Indicator_Link_Indicators> Indicator_Link_Indicators { get; set; }
		public virtual ICollection<Indicator_Link_Fields> Indicator_Link_Fields { get; set; }


	}

	public class Indicator_Link_Indicators
	{
		[Key]
		public Int16 Indicator_Link_Indicator_ID { get; set; }
		public Int16 Indicator_ID { get; set; }
		public Int16 Link_ID { get; set; }

		public virtual Indicators Indicator { get; set; }
		public virtual Indicator_Links Link { get; set; }
	}

	public class Indicator_Link_Fields
	{
		[Key]
		public Int16 Indicator_Link_Field_ID { get; set; }
		public Int16 Link_Field_ID { get; set; }
		public Int16 Link_ID { get; set; }

		public virtual Indicator_Links Indicator_Link { get; set; }
		public virtual Link_Fields Link_Field { get; set; }

	}

	public class Link_Fields
	{
		[Key]
		public Int16 Link_Field_ID { get; set; }
		public string Link_Field { get; set; }

		public virtual ICollection<Link_Fields_Properties> Link_Fields_Properties { get; set; }
	}

	public class Link_Fields_Properties
	{
		[Key]
		public Int16 Link_Field_Property_ID { get; set; }
		public Int16 Link_Field_ID { get; set; }
		public string Link_Field_Property { get; set; }

		public virtual Link_Fields Link_Field { get; set; }
	}


	public class Indicator_CoE_Maps
	{
		[Key]
		public Int16 Map_ID { get; set; }
		public Int16 CoE_ID { get; set; }
		public Int16 Indicator_ID { get; set; }
		[Display(Name = "#")]
		public Int16 Number { get; set; }
		public Int16 Fiscal_Year { get; set; }

		public virtual CoEs CoE { get; set; }
		public virtual Indicators Indicator { get; set; }
	}

	public class Areas
	{
		[Key]
		public Int16 Area_ID { get; set; }
		public string Area { get; set; }
		public Int16 Sort { get; set; }

		public virtual ICollection<Indicators> Indicator { get; set; }
		public virtual ICollection<Area_CoE_Maps> Area_CoE_Map { get; set; }
	}

	public class Area_CoE_Maps
	{
		[Key]
		public Int16 Map_ID { get; set; }
		public Int16 CoE_ID { get; set; }
		public Int16 Area_ID { get; set; }
		public string Objective { get; set; }
		public Int16 Fiscal_Year { get; set; }

		public virtual CoEs CoE { get; set; }
		public virtual Areas Area { get; set; }
	}

	public class Footnotes
	{
		[Key]
		public Int16 Footnote_ID { get; set; }
		public string Footnote { get; set; }
		public string Footnote_Symbol { get; set; }
		public Int16 Footnote_Order { get; set; }
		public virtual ICollection<Indicator_Footnote_Maps> Indicator_Footnote_Map { get; set; }
	}

	public class Indicator_Footnote_Maps
	{
		[Key]
		public Int16 Map_ID { get; set; }
		public Int16 Footnote_ID { get; set; }
		public Int16 Indicator_ID { get; set; }
		public Int16 Fiscal_Year { get; set; }

		public virtual Footnotes Footnote { get; set; }
		public virtual Indicators Indicator { get; set; }
	}

	public class Analysts
	{
		[Key]
		public Int16 Analyst_ID { get; set; }
		public string Last_Name { get; set; }
		public string First_Name { get; set; }
		public string Position { get; set; }
		public Int16 Order { get; set; }
	}

	public class Formats
	{
		[Key]
		public Int16 Format_ID { get; set; }
		public string Format_Type { get; set; }
		public string Format_Code { get; set; }
		public Int16 Order { get; set; }
		public string Format_Code_C { get; set; }
	}

	public class Color_Types
	{
		[Key]
		public Int16 Color_ID { get; set; }
		public String Color_Type { get; set; }
	}

	public class Color_Directions
	{
		[Key]
		public Int16 Direction_ID { get; set; }
		public String Direction { get; set; }
	}

	public class Color_Thresholds
	{
		[Key]
		public Int16 Threshold_ID { get; set; }
		public String Threshold { get; set; }
	}

	public class Fiscal_Years
	{
		[Key]
		public Int16 Fiscal_Year_ID { get; set; }
		public string Fiscal_Year { get; set; }
		public Int16 Fiscal_Year_Code { get; set; }
	}

	public class Words
	{
		[Key]
		public Int16 ID { get; set; }
		public string Word { get; set; }
	}

	public class InventoryDBContext : DbContext
	{
		public DbSet<Indicators> Indicators { get; set; }
		public DbSet<CoEs> CoEs { get; set; }
		public DbSet<Areas> Areas { get; set; }
		public DbSet<Footnotes> Footnotes { get; set; }
		public DbSet<Color_Types> Color_Types { get; set; }
		public DbSet<Color_Thresholds> Color_Thresholds { get; set; }
		public DbSet<Color_Directions> Color_Directions { get; set; }
		public DbSet<Formats> Formats { get; set; }
		public DbSet<Fiscal_Years> Fiscal_Years { get; set; }
		public DbSet<Words> Words { get; set; }

		public DbSet<Indicator_CoE_Maps> Indicator_CoE_Maps { get; set; }
		public DbSet<Area_CoE_Maps> Area_CoE_Maps { get; set; }
		public DbSet<Indicator_Footnote_Maps> Indicator_Footnote_Maps { get; set; }

		public DbSet<Indicator_Links> Indicator_Links { get; set; }
		public DbSet<Link_Fields> Link_Fields { get; set; }
		public DbSet<Link_Fields_Properties> Link_Fields_Properties { get; set; }
		public DbSet<Indicator_Link_Indicators> Indicator_Link_Indicators { get; set; }
		public DbSet<Indicator_Link_Fields> Indicator_Link_Fields { get; set; }

		public DbSet<Analysts> Analysts { get; set; }

		public DbSet<Link_CoEs> Link_CoEs { get; set; }
		public DbSet<Link_CoE_Maps> Link_CoE_Maps { get; set; }

		//public InventoryDBContext()
		//    : base("Indicator_Inventory")
		//{
		//}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<CoEs>().HasMany(c => c.Indicator_CoE_Map).WithRequired(p => p.CoE).HasForeignKey(c => c.CoE_ID);
			//modelBuilder.Entity<CoEs>().
			//  HasMany(c => c.Indicator_CoE_Map).
			//  WithMany(p => p.CoE).
			//  Map(
			//   m =>
			//   {
			//       m.MapLeftKey("CoE_ID");
			//       m.MapRightKey("Map_ID");
			//       m.ToTable("Indicator_CoE_Maps");
			//   });

			//modelBuilder.Entity<Indicators>().
			//  HasMany(c => c.Indicator_CoE_Map).
			//  WithMany(p => p.Indicator).
			//  Map(
			//   m =>
			//   {
			//       m.MapLeftKey("CoE_ID");
			//       m.MapRightKey("Map_ID");
			//       m.ToTable("Indicator_CoE_Maps");
			//   });

			//modelBuilder.Entity<Areas>().
			//      HasMany(c => c.CoE).
			//      WithMany(p => p.Area).
			//      Map(
			//       m =>
			//       {
			//           m.MapLeftKey("Area_ID");
			//           m.MapRightKey("CoE_ID");
			//           m.ToTable("Objective_Maps");
			//       });

		}
	}
}

