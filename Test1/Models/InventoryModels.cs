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
        public string FY_13_14_Performance_Threshold { get; set; }
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

        public virtual string FY_13_14_Q1_Color { get { return Color.getColor(FY_13_14_Q1, FY_13_14_Target, FY_13_14_Q1_Sup, FY_13_14_Q1_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID); } }
        public virtual string FY_13_14_Q2_Color { get { return Color.getColor(FY_13_14_Q2, FY_13_14_Target, FY_13_14_Q2_Sup, FY_13_14_Q2_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID); } }
        public virtual string FY_13_14_Q3_Color { get { return Color.getColor(FY_13_14_Q3, FY_13_14_Target, FY_13_14_Q3_Sup, FY_13_14_Q3_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID); } }
        public virtual string FY_13_14_Q4_Color { get { return Color.getColor(FY_13_14_Q4, FY_13_14_Target, FY_13_14_Q4_Sup, FY_13_14_Q4_Custom_Color, FY_13_14_Color_ID, false, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID); } }
        public virtual string FY_13_14_YTD_Color { get { return Color.getColor(FY_13_14_YTD, FY_13_14_Target, FY_13_14_YTD, FY_13_14_YTD_Custom_Color, FY_13_14_Color_ID, true, this, FY_13_14_Threshold_ID, FY_13_14_Direction_ID); } }



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
        public string FY_14_15_Performance_Threshold { get; set; }
        public string FY_14_15_Performance_Threshold_Sup { get; set; }
        public Int16 FY_14_15_Color_ID { get; set; }
        public Int16 FY_14_15_Threshold_ID { get; set; }
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

        public virtual string FY_14_15_Q1_Color { get { return Color.getColor(FY_14_15_Q1, FY_14_15_Target, FY_13_14_Q1_Sup, FY_14_15_Q1_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID); } }
        public virtual string FY_14_15_Q2_Color { get { return Color.getColor(FY_14_15_Q2, FY_14_15_Target, FY_13_14_Q2_Sup, FY_14_15_Q2_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID); } }
        public virtual string FY_14_15_Q3_Color { get { return Color.getColor(FY_14_15_Q3, FY_14_15_Target, FY_13_14_Q3_Sup, FY_14_15_Q3_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID); } }
        public virtual string FY_14_15_Q4_Color { get { return Color.getColor(FY_14_15_Q4, FY_14_15_Target, FY_13_14_Q4_Sup, FY_14_15_Q4_Custom_Color, FY_14_15_Color_ID, false, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID); } }
        public virtual string FY_14_15_YTD_Color { get { return Color.getColor(FY_14_15_YTD, FY_14_15_Target, FY_13_14_YTD, FY_14_15_YTD_Custom_Color, FY_14_15_Color_ID, true, this, FY_14_15_Threshold_ID, FY_14_15_Direction_ID); } }

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

        public virtual ICollection<Indicator_CoE_Maps> Indicator_CoE_Map { get; set; }
        public virtual ICollection<Area_CoE_Maps> Area_CoE_Map { get; set; }
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

        public DbSet<Indicator_CoE_Maps> Indicator_CoE_Maps { get; set; }
        public DbSet<Area_CoE_Maps> Area_CoE_Maps { get; set; }
        public DbSet<Indicator_Footnote_Maps> Indicator_Footnote_Maps { get; set; }

        public DbSet<Analysts> Analysts { get; set; }

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

