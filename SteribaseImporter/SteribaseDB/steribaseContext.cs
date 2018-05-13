using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SteribaseImporter.SteribaseDB
{
    public partial class steribaseContext : DbContext
    {
        public virtual DbSet<Applform> Applform { get; set; }
        public virtual DbSet<Applgeraet> Applgeraet { get; set; }
        public virtual DbSet<Applweg> Applweg { get; set; }
        public virtual DbSet<Art> Art { get; set; }
        public virtual DbSet<Artaufbtyp> Artaufbtyp { get; set; }
        public virtual DbSet<Artb> Artb { get; set; }
        public virtual DbSet<Artlager> Artlager { get; set; }
        public virtual DbSet<Arttyp> Arttyp { get; set; }
        public virtual DbSet<Artzubfkt> Artzubfkt { get; set; }
        public virtual DbSet<Dostyp> Dostyp { get; set; }
        public virtual DbSet<Gp> Gp { get; set; }
        public virtual DbSet<Gpgr> Gpgr { get; set; }
        public virtual DbSet<Kostenstellen> Kostenstellen { get; set; }
        public virtual DbSet<Krkasubtyp> Krkasubtyp { get; set; }
        public virtual DbSet<Krkatyp> Krkatyp { get; set; }
        public virtual DbSet<Lagerbed> Lagerbed { get; set; }
        public virtual DbSet<Lagerort> Lagerort { get; set; }
        public virtual DbSet<Lightprotdfn> Lightprotdfn { get; set; }
        public virtual DbSet<Patdisp> Patdisp { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<St> St { get; set; }
        public virtual DbSet<Stationen> Stationen { get; set; }
        public virtual DbSet<Taxtyp> Taxtyp { get; set; }
        public virtual DbSet<Tl> Tl { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Usr> Usr { get; set; }
        public virtual DbSet<Verstat> Verstat { get; set; }
        public virtual DbSet<Zub> Zub { get; set; }
        public virtual DbSet<Zubartdoku> Zubartdoku { get; set; }
        public virtual DbSet<Zubdet> Zubdet { get; set; }
        public virtual DbSet<Zubdetimprel> Zubdetimprel { get; set; }
        public virtual DbSet<Zubkat> Zubkat { get; set; }
        public virtual DbSet<Zubstatus> Zubstatus { get; set; }

        // Unable to generate entity type for table 'ext_pat'. Please see the warning messages.
        // Unable to generate entity type for table 'gpgpgr'. Please see the warning messages.
        // Unable to generate entity type for table 'gpkrka'. Please see the warning messages.
        // Unable to generate entity type for table 'gppat'. Please see the warning messages.
        // Unable to generate entity type for table 'mgmtinfo'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=;database=steribase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applform>(entity =>
            {
                entity.HasKey(e => e.ApplFid);

                entity.ToTable("applform");

                entity.Property(e => e.ApplFid)
                    .HasColumnName("ApplFID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplFbesch)
                    .HasColumnName("ApplFBesch")
                    .HasMaxLength(200);

                entity.Property(e => e.ApplFbez)
                    .HasColumnName("ApplFBez")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Applgeraet>(entity =>
            {
                entity.HasKey(e => e.ApplGid);

                entity.ToTable("applgeraet");

                entity.Property(e => e.ApplGid)
                    .HasColumnName("ApplGID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplGbesch)
                    .HasColumnName("ApplGBesch")
                    .HasMaxLength(200);

                entity.Property(e => e.ApplGbez)
                    .HasColumnName("ApplGBez")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Applweg>(entity =>
            {
                entity.HasKey(e => e.ApplWid);

                entity.ToTable("applweg");

                entity.Property(e => e.ApplWid)
                    .HasColumnName("ApplWID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplWbesch)
                    .HasColumnName("ApplWBesch")
                    .HasMaxLength(200);

                entity.Property(e => e.ApplWbez)
                    .HasColumnName("ApplWBez")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Art>(entity =>
            {
                entity.ToTable("art");

                entity.HasIndex(e => e.ArtBid)
                    .HasName("ArtBID");

                entity.HasIndex(e => e.ArtTypId)
                    .HasName("ArtTypID");

                entity.Property(e => e.ArtId)
                    .HasColumnName("ArtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtAnbiet).HasColumnType("int(11)");

                entity.Property(e => e.ArtAnbrHaltbD).HasColumnType("int(11)");

                entity.Property(e => e.ArtAnbrHaltbH).HasColumnType("int(11)");

                entity.Property(e => e.ArtAnbrHaltbIgnoreForZubHaltb).HasMaxLength(200);

                entity.Property(e => e.ArtAnbrHaltbM).HasColumnType("int(11)");

                entity.Property(e => e.ArtAnbrIsPos).HasMaxLength(200);

                entity.Property(e => e.ArtAnbrTmminPart).HasColumnName("ArtAnbrTMMinPart");

                entity.Property(e => e.ArtAufbTypId)
                    .HasColumnName("ArtAufbTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtAv)
                    .HasColumnName("ArtAV")
                    .HasMaxLength(200);

                entity.Property(e => e.ArtBestMinVe)
                    .HasColumnName("ArtBestMinVE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtBez).HasMaxLength(200);

                entity.Property(e => e.ArtBid)
                    .HasColumnName("ArtBID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtDataInpOk)
                    .HasColumnName("ArtDataInpOK")
                    .HasMaxLength(200);

                entity.Property(e => e.ArtFreeForPrd).HasMaxLength(200);

                entity.Property(e => e.ArtHaltbMon).HasColumnType("int(11)");

                entity.Property(e => e.ArtHerst).HasColumnType("int(11)");

                entity.Property(e => e.ArtIdusr)
                    .HasColumnName("ArtIDUsr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtImportReimportAbda)
                    .HasColumnName("ArtImport_Reimport_ABDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtInsDat).HasColumnType("datetime");

                entity.Property(e => e.ArtIsApplB).HasMaxLength(200);

                entity.Property(e => e.ArtIsSubArt).HasMaxLength(200);

                entity.Property(e => e.ArtIsTltyp)
                    .HasColumnName("ArtIsTLTyp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtKztmp)
                    .HasColumnName("ArtKZTmp")
                    .HasMaxLength(200);

                entity.Property(e => e.ArtLag).HasMaxLength(200);

                entity.Property(e => e.ArtLagBed).HasColumnType("int(11)");

                entity.Property(e => e.ArtLagBedAnbr).HasColumnType("int(11)");

                entity.Property(e => e.ArtMasterArtId)
                    .HasColumnName("ArtMasterArtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtMinOrderVe)
                    .HasColumnName("ArtMinOrderVE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtMwStTyp).HasMaxLength(200);

                entity.Property(e => e.ArtPzn)
                    .HasColumnName("ArtPZN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtSt)
                    .HasColumnName("ArtST")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtStdLag).HasColumnType("int(11)");

                entity.Property(e => e.ArtStdLagAnbr).HasColumnType("int(11)");

                entity.Property(e => e.ArtStdLagWe)
                    .HasColumnName("ArtStdLagWE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtStdLief).HasColumnType("int(11)");

                entity.Property(e => e.ArtStdsupplDays)
                    .HasColumnName("ArtSTDSupplDays")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTaxTypIdartAbv)
                    .HasColumnName("ArtTaxTypIDArtAbv")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTm)
                    .HasColumnName("ArtTM")
                    .HasMaxLength(200);

                entity.Property(e => e.ArtTmanz)
                    .HasColumnName("ArtTMAnz")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmdos)
                    .HasColumnName("ArtTMDos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmdosTax)
                    .HasColumnName("ArtTMDosTax")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmdosUnit)
                    .HasColumnName("ArtTMDosUnit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmvolDecl)
                    .HasColumnName("ArtTMVolDecl")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmvolFill)
                    .HasColumnName("ArtTMVolFill")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmvolMax)
                    .HasColumnName("ArtTMVolMax")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmvolUnit)
                    .HasColumnName("ArtTMVolUnit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTypId)
                    .HasColumnName("ArtTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtVe)
                    .HasColumnName("ArtVE")
                    .HasMaxLength(200);

                entity.Property(e => e.ArtVertriebAbDat).HasColumnType("datetime");

                entity.Property(e => e.ArtVerwTypId)
                    .HasColumnName("ArtVerwTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoSyncToAbda)
                    .HasColumnName("NoSyncToABDA")
                    .HasMaxLength(200);

                entity.HasOne(d => d.ArtB)
                    .WithMany(p => p.Art)
                    .HasForeignKey(d => d.ArtBid)
                    .HasConstraintName("art_ibfk_1");

                entity.HasOne(d => d.ArtTyp)
                    .WithMany(p => p.Art)
                    .HasForeignKey(d => d.ArtTypId)
                    .HasConstraintName("art_ibfk_2");
            });

            modelBuilder.Entity<Artaufbtyp>(entity =>
            {
                entity.HasKey(e => e.AufbTypId);

                entity.ToTable("artaufbtyp");

                entity.Property(e => e.AufbTypId)
                    .HasColumnName("AufbTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AufbTypBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Artb>(entity =>
            {
                entity.ToTable("artb");

                entity.Property(e => e.ArtBid)
                    .HasColumnName("ArtBID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtBbez)
                    .HasColumnName("ArtBBez")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Artlager>(entity =>
            {
                entity.HasKey(e => e.ArtLagId);

                entity.ToTable("artlager");

                entity.HasIndex(e => e.ArtId)
                    .HasName("ArtID");

                entity.Property(e => e.ArtLagId)
                    .HasColumnName("ArtLagID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtAnbiet).HasColumnType("int(11)");

                entity.Property(e => e.ArtChB).HasMaxLength(200);

                entity.Property(e => e.ArtDosUnit).HasColumnType("int(11)");

                entity.Property(e => e.ArtHerst).HasColumnType("int(11)");

                entity.Property(e => e.ArtId)
                    .HasColumnName("ArtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtSt)
                    .HasColumnName("ArtST")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmanz)
                    .HasColumnName("ArtTMAnz")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmdos)
                    .HasColumnName("ArtTMDos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmvolDecl)
                    .HasColumnName("ArtTMVolDecl")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmvolFill)
                    .HasColumnName("ArtTMVolFill")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtVolUnit).HasColumnType("int(11)");

                entity.Property(e => e.AufbTlid)
                    .HasColumnName("AufbTLID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Art)
                    .WithMany(p => p.Artlager)
                    .HasForeignKey(d => d.ArtId)
                    .HasConstraintName("artlager_ibfk_1");
            });

            modelBuilder.Entity<Arttyp>(entity =>
            {
                entity.ToTable("arttyp");

                entity.Property(e => e.ArtTypId)
                    .HasColumnName("ArtTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTypBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Artzubfkt>(entity =>
            {
                entity.ToTable("artzubfkt");

                entity.Property(e => e.ArtZubFktId)
                    .HasColumnName("ArtZubFktID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddOrderInDoku).HasColumnType("int(11)");

                entity.Property(e => e.ArtZubFktBesch).HasMaxLength(200);

                entity.Property(e => e.ArtZubFktBez).HasMaxLength(200);

                entity.Property(e => e.ArtZubFktKz)
                    .HasColumnName("ArtZubFktKZ")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Dostyp>(entity =>
            {
                entity.ToTable("dostyp");

                entity.Property(e => e.DosTypId)
                    .HasColumnName("DosTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AbsRel).HasMaxLength(200);

                entity.Property(e => e.DosTypBesch).HasMaxLength(200);

                entity.Property(e => e.DosTypBez).HasMaxLength(200);

                entity.Property(e => e.DosTypRel).HasMaxLength(200);

                entity.Property(e => e.SysDs)
                    .HasColumnName("SysDS")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Gp>(entity =>
            {
                entity.ToTable("gp");

                entity.Property(e => e.Gpid)
                    .HasColumnName("GPID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Archiv).HasMaxLength(200);

                entity.Property(e => e.Bundesland).HasMaxLength(200);

                entity.Property(e => e.GebDat).HasColumnType("datetime");

                entity.Property(e => e.Gpanrede)
                    .HasColumnName("GPAnrede")
                    .HasMaxLength(200);

                entity.Property(e => e.GpfaName)
                    .HasColumnName("GPFaName")
                    .HasMaxLength(200);

                entity.Property(e => e.Gpkurz)
                    .HasColumnName("GPKurz")
                    .HasMaxLength(200);

                entity.Property(e => e.Gpmessage)
                    .HasColumnName("GPMessage")
                    .HasMaxLength(200);

                entity.Property(e => e.Gpname)
                    .HasColumnName("GPName")
                    .HasMaxLength(200);

                entity.Property(e => e.Gptitel)
                    .HasColumnName("GPTitel")
                    .HasMaxLength(200);

                entity.Property(e => e.Gpvorname)
                    .HasColumnName("GPVorname")
                    .HasMaxLength(200);

                entity.Property(e => e.KeyAdrAbda)
                    .HasColumnName("Key_ADR_ABDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KvarztNr)
                    .HasColumnName("KVArztNr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KvbetrStNr)
                    .HasColumnName("KVBetrStNr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KvbzkId)
                    .HasColumnName("KVBzkID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nation).HasMaxLength(200);

                entity.Property(e => e.Ort).HasMaxLength(200);

                entity.Property(e => e.OrtPostf).HasMaxLength(200);

                entity.Property(e => e.Plz)
                    .HasColumnName("PLZ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Plzpostf)
                    .HasColumnName("PLZPostf")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Postf).HasColumnType("int(11)");

                entity.Property(e => e.Sex).HasMaxLength(200);

                entity.Property(e => e.Strasse).HasMaxLength(200);
            });

            modelBuilder.Entity<Gpgr>(entity =>
            {
                entity.ToTable("gpgr");

                entity.Property(e => e.GpgrId)
                    .HasColumnName("GPGrID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Gpgruppe)
                    .HasColumnName("GPGruppe")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Kostenstellen>(entity =>
            {
                entity.HasKey(e => e.KostId);

                entity.ToTable("kostenstellen");

                entity.Property(e => e.KostId)
                    .HasColumnName("KostID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KostBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Krkasubtyp>(entity =>
            {
                entity.ToTable("krkasubtyp");

                entity.Property(e => e.KrKaSubTypId)
                    .HasColumnName("KrKaSubTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KrKaSubTypBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Krkatyp>(entity =>
            {
                entity.ToTable("krkatyp");

                entity.Property(e => e.KrKaTypId)
                    .HasColumnName("KrKaTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Lagerbed>(entity =>
            {
                entity.HasKey(e => e.LagBedId);

                entity.ToTable("lagerbed");

                entity.Property(e => e.LagBedId)
                    .HasColumnName("LagBedID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LagBed).HasMaxLength(200);
            });

            modelBuilder.Entity<Lagerort>(entity =>
            {
                entity.HasKey(e => e.LagOrtId);

                entity.ToTable("lagerort");

                entity.HasIndex(e => e.LagBedId)
                    .HasName("LagBedID");

                entity.Property(e => e.LagOrtId)
                    .HasColumnName("LagOrtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active).HasMaxLength(200);

                entity.Property(e => e.LagBedId)
                    .HasColumnName("LagBedID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LagOrtBez).HasMaxLength(200);

                entity.Property(e => e.PrdLineLag).HasMaxLength(200);

                entity.Property(e => e.SperrLagTypId)
                    .HasColumnName("SperrLagTypID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.LagBed)
                    .WithMany(p => p.Lagerort)
                    .HasForeignKey(d => d.LagBedId)
                    .HasConstraintName("lagerort_ibfk_1");
            });

            modelBuilder.Entity<Lightprotdfn>(entity =>
            {
                entity.HasKey(e => e.LightProtId);

                entity.ToTable("lightprotdfn");

                entity.Property(e => e.LightProtId)
                    .HasColumnName("LightProtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LightProtName).HasMaxLength(200);
            });

            modelBuilder.Entity<Patdisp>(entity =>
            {
                entity.ToTable("patdisp");

                entity.Property(e => e.PatDispId)
                    .HasColumnName("PatDispID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PatDispBez).HasMaxLength(200);

                entity.Property(e => e.PatDispMemo).HasMaxLength(200);
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.ToTable("sex");

                entity.Property(e => e.SexId)
                    .HasColumnName("SexID")
                    .HasMaxLength(200);

                entity.Property(e => e.SexBez).HasMaxLength(200);
            });

            modelBuilder.Entity<St>(entity =>
            {
                entity.ToTable("st");

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StbezInn)
                    .HasColumnName("STBezINN")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Stationen>(entity =>
            {
                entity.HasKey(e => e.StatId);

                entity.ToTable("stationen");

                entity.Property(e => e.StatId)
                    .HasColumnName("StatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Taxtyp>(entity =>
            {
                entity.ToTable("taxtyp");

                entity.Property(e => e.TaxTypId)
                    .HasColumnName("TaxTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaxTypBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Tl>(entity =>
            {
                entity.ToTable("tl");

                entity.Property(e => e.Tlid)
                    .HasColumnName("TLID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tlbesch)
                    .HasColumnName("TLBesch")
                    .HasMaxLength(200);

                entity.Property(e => e.Tlbez)
                    .HasColumnName("TLBez")
                    .HasMaxLength(200);

                entity.Property(e => e.Tldens).HasColumnName("TLDens");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("units");

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnitKz)
                    .HasColumnName("UnitKZ")
                    .HasMaxLength(200);

                entity.Property(e => e.UnitText).HasMaxLength(200);
            });

            modelBuilder.Entity<Usr>(entity =>
            {
                entity.ToTable("usr");

                entity.Property(e => e.UsrId)
                    .HasColumnName("UsrID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsrName).HasMaxLength(200);

                entity.Property(e => e.UsrShort).HasMaxLength(200);
            });

            modelBuilder.Entity<Verstat>(entity =>
            {
                entity.ToTable("verstat");

                entity.Property(e => e.VerStatId)
                    .HasColumnName("VerStatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VersStatBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Zub>(entity =>
            {
                entity.ToTable("zub");

                entity.HasIndex(e => e.KostId)
                    .HasName("KostID");

                entity.HasIndex(e => e.PatDispId)
                    .HasName("PatDispID");

                entity.HasIndex(e => e.StatId)
                    .HasName("StatID");

                entity.Property(e => e.ZubId)
                    .HasColumnName("ZubID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnfordDat).HasColumnType("datetime");

                entity.Property(e => e.AuftrGeb).HasColumnType("int(11)");

                entity.Property(e => e.AuftrVerm).HasColumnType("int(11)");

                entity.Property(e => e.DiagStdid)
                    .HasColumnName("DiagSTDID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KostId)
                    .HasColumnName("KostID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LohnAuftrGeb).HasColumnType("int(11)");

                entity.Property(e => e.LohnHerst).HasColumnType("int(11)");

                entity.Property(e => e.PatDispId)
                    .HasColumnName("PatDispID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PatGebDat).HasColumnType("datetime");

                entity.Property(e => e.PatGew).HasColumnType("int(11)");

                entity.Property(e => e.PatGewIdeal).HasMaxLength(200);

                entity.Property(e => e.PatGewReal).HasColumnType("int(11)");

                entity.Property(e => e.PatGr).HasColumnType("int(11)");

                entity.Property(e => e.PatKof).HasColumnName("PatKOF");

                entity.Property(e => e.PatSex).HasMaxLength(200);

                entity.Property(e => e.PatVerStatId)
                    .HasColumnName("PatVerStatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Patient).HasColumnType("int(11)");

                entity.Property(e => e.Pdid)
                    .HasColumnName("PDID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pkid)
                    .HasColumnName("PKID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatId)
                    .HasColumnName("StatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Verordner).HasColumnType("int(11)");

                entity.Property(e => e.ZyklNr).HasColumnType("int(11)");

                entity.HasOne(d => d.Kost)
                    .WithMany(p => p.Zub)
                    .HasForeignKey(d => d.KostId)
                    .HasConstraintName("zub_ibfk_2");

                entity.HasOne(d => d.PatDisp)
                    .WithMany(p => p.Zub)
                    .HasForeignKey(d => d.PatDispId)
                    .HasConstraintName("zub_ibfk_3");

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.Zub)
                    .HasForeignKey(d => d.StatId)
                    .HasConstraintName("zub_ibfk_1");
            });

            modelBuilder.Entity<Zubartdoku>(entity =>
            {
                entity.ToTable("zubartdoku");

                entity.HasIndex(e => e.ArtId)
                    .HasName("ArtID");

                entity.HasIndex(e => e.ArtLagId)
                    .HasName("ArtLagID");

                entity.HasIndex(e => e.AufbTypId)
                    .HasName("AufbTypID");

                entity.HasIndex(e => e.Stid)
                    .HasName("STID");

                entity.HasIndex(e => e.UsrId)
                    .HasName("UsrID");

                entity.HasIndex(e => e.ZubDetId)
                    .HasName("ZubDetID");

                entity.HasIndex(e => e.ZubId)
                    .HasName("ZubID");

                entity.HasIndex(e => e.ZubKatId)
                    .HasName("ZubKatID");

                entity.Property(e => e.ZubArtDokuId)
                    .HasColumnName("ZubArtDokuID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Anbruch).HasMaxLength(200);

                entity.Property(e => e.ArtBez).HasMaxLength(200);

                entity.Property(e => e.ArtChB).HasMaxLength(200);

                entity.Property(e => e.ArtFkt).HasColumnType("int(11)");

                entity.Property(e => e.ArtFktTlid)
                    .HasColumnName("ArtFktTLID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtId)
                    .HasColumnName("ArtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtLagId)
                    .HasColumnName("ArtLagID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtPzn)
                    .HasColumnName("ArtPZN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmanz)
                    .HasColumnName("ArtTMAnz")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTmdos).HasColumnName("ArtTMDos");

                entity.Property(e => e.ArtTmvolAdForRek).HasColumnName("ArtTMVolAdForRek");

                entity.Property(e => e.ArtTmvolDecl).HasColumnName("ArtTMVolDecl");

                entity.Property(e => e.ArtTmvolFill).HasColumnName("ArtTMVolFill");

                entity.Property(e => e.AufbSubArtId)
                    .HasColumnName("AufbSubArtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AufbTlid)
                    .HasColumnName("AufbTLID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AufbTypId)
                    .HasColumnName("AufbTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AusAnbr).HasMaxLength(200);

                entity.Property(e => e.DokuDat).HasColumnType("datetime");

                entity.Property(e => e.DosUnit).HasColumnType("int(11)");

                entity.Property(e => e.EndlessChB).HasMaxLength(200);

                entity.Property(e => e.HaltbDat).HasColumnType("datetime");

                entity.Property(e => e.IsApplB).HasMaxLength(200);

                entity.Property(e => e.MixNr).HasColumnType("int(11)");

                entity.Property(e => e.RekExAbtl)
                    .HasColumnName("RekExABTL")
                    .HasMaxLength(200);

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsrId)
                    .HasColumnName("UsrID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Verbraucht).HasMaxLength(200);

                entity.Property(e => e.VolCountsForSum).HasMaxLength(200);

                entity.Property(e => e.VolUnit).HasColumnType("int(11)");

                entity.Property(e => e.ZubDetId)
                    .HasColumnName("ZubDetID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZubId)
                    .HasColumnName("ZubID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZubKatId)
                    .HasColumnName("ZubKatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZubMixId)
                    .HasColumnName("ZubMixID")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Art)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.ArtId)
                    .HasConstraintName("zubartdoku_ibfk_5");

                entity.HasOne(d => d.ArtLag)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.ArtLagId)
                    .HasConstraintName("zubartdoku_ibfk_4");

                entity.HasOne(d => d.AufbTyp)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.AufbTypId)
                    .HasConstraintName("zubartdoku_ibfk_7");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.Stid)
                    .HasConstraintName("zubartdoku_ibfk_6");

                entity.HasOne(d => d.Usr)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.UsrId)
                    .HasConstraintName("zubartdoku_ibfk_8");

                entity.HasOne(d => d.ZubDet)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.ZubDetId)
                    .HasConstraintName("zubartdoku_ibfk_3");

                entity.HasOne(d => d.Zub)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.ZubId)
                    .HasConstraintName("zubartdoku_ibfk_1");

                entity.HasOne(d => d.ZubKat)
                    .WithMany(p => p.Zubartdoku)
                    .HasForeignKey(d => d.ZubKatId)
                    .HasConstraintName("zubartdoku_ibfk_2");
            });

            modelBuilder.Entity<Zubdet>(entity =>
            {
                entity.ToTable("zubdet");

                entity.HasIndex(e => e.ApplFid)
                    .HasName("ApplFID");

                entity.HasIndex(e => e.ApplGid)
                    .HasName("ApplGID");

                entity.HasIndex(e => e.ApplWid)
                    .HasName("ApplWID");

                entity.HasIndex(e => e.DosTypId)
                    .HasName("DosTypID");

                entity.HasIndex(e => e.Stid)
                    .HasName("STID");

                entity.HasIndex(e => e.Tlid)
                    .HasName("TLID");

                entity.HasIndex(e => e.ZubId)
                    .HasName("ZubID");

                entity.HasIndex(e => e.ZubKatId)
                    .HasName("ZubKatID");

                entity.HasIndex(e => e.ZubStatId)
                    .HasName("ZubStatID");

                entity.Property(e => e.ZubDetId)
                    .HasColumnName("ZubDetID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplB).HasColumnType("int(11)");

                entity.Property(e => e.ApplBdivCnt)
                    .HasColumnName("ApplBDivCnt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplD).HasColumnType("int(11)");

                entity.Property(e => e.ApplDat).HasColumnType("datetime");

                entity.Property(e => e.ApplDunit)
                    .HasColumnName("ApplDUnit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplFid)
                    .HasColumnName("ApplFID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplGid)
                    .HasColumnName("ApplGID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplWid)
                    .HasColumnName("ApplWID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutIdem).HasMaxLength(200);

                entity.Property(e => e.DosTypId)
                    .HasColumnName("DosTypID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DosUnit).HasColumnType("int(11)");

                entity.Property(e => e.HaltbBed1).HasColumnType("int(11)");

                entity.Property(e => e.HaltbBed2).HasColumnType("int(11)");

                entity.Property(e => e.HerstDat).HasColumnType("datetime");

                entity.Property(e => e.LightProt).HasColumnType("int(11)");

                entity.Property(e => e.MixNr).HasColumnType("int(11)");

                entity.Property(e => e.PosAnz).HasColumnType("int(11)");

                entity.Property(e => e.StherstPref)
                    .HasColumnName("STHerstPref")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stid)
                    .HasColumnName("STID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TagNr).HasColumnType("int(11)");

                entity.Property(e => e.Tlid)
                    .HasColumnName("TLID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VolUnit).HasColumnType("int(11)");

                entity.Property(e => e.ZubId)
                    .HasColumnName("ZubID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZubKatId)
                    .HasColumnName("ZubKatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZubMixId)
                    .HasColumnName("ZubMixID")
                    .HasMaxLength(200);

                entity.Property(e => e.ZubStatId)
                    .HasColumnName("ZubStatID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ApplF)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.ApplFid)
                    .HasConstraintName("zubdet_ibfk_8");

                entity.HasOne(d => d.ApplG)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.ApplGid)
                    .HasConstraintName("zubdet_ibfk_9");

                entity.HasOne(d => d.ApplW)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.ApplWid)
                    .HasConstraintName("zubdet_ibfk_7");

                entity.HasOne(d => d.DosTyp)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.DosTypId)
                    .HasConstraintName("zubdet_ibfk_5");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.Stid)
                    .HasConstraintName("zubdet_ibfk_4");

                entity.HasOne(d => d.Tl)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.Tlid)
                    .HasConstraintName("zubdet_ibfk_6");

                entity.HasOne(d => d.Zub)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.ZubId)
                    .HasConstraintName("zubdet_ibfk_1");

                entity.HasOne(d => d.ZubKat)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.ZubKatId)
                    .HasConstraintName("zubdet_ibfk_2");

                entity.HasOne(d => d.ZubStat)
                    .WithMany(p => p.Zubdet)
                    .HasForeignKey(d => d.ZubStatId)
                    .HasConstraintName("zubdet_ibfk_3");
            });

            modelBuilder.Entity<Zubdetimprel>(entity =>
            {
                entity.HasKey(e => e.RelId);

                entity.ToTable("zubdetimprel");

                entity.HasIndex(e => e.ZubDetId)
                    .HasName("ZubDetID");

                entity.Property(e => e.RelId)
                    .HasColumnName("RelID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExpFileName).HasMaxLength(200);

                entity.Property(e => e.ExtApplId)
                    .HasColumnName("ExtApplID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExtSysId)
                    .HasColumnName("ExtSysID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExtZubDetId)
                    .HasColumnName("ExtZubDetID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsDat).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.ZubDetId)
                    .HasColumnName("ZubDetID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ZubDet)
                    .WithMany(p => p.Zubdetimprel)
                    .HasForeignKey(d => d.ZubDetId)
                    .HasConstraintName("zubdetimprel_ibfk_1");
            });

            modelBuilder.Entity<Zubkat>(entity =>
            {
                entity.ToTable("zubkat");

                entity.Property(e => e.ZubKatId)
                    .HasColumnName("ZubKatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZubKatBesch).HasMaxLength(200);

                entity.Property(e => e.ZubKatBez).HasMaxLength(200);
            });

            modelBuilder.Entity<Zubstatus>(entity =>
            {
                entity.HasKey(e => e.ZubStatId);

                entity.ToTable("zubstatus");

                entity.Property(e => e.ZubStatId)
                    .HasColumnName("ZubStatID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZubStatBez).HasMaxLength(200);
            });
        }
    }
}
