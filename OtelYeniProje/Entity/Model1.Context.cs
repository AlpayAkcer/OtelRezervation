﻿namespace OtelYeniProje.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public partial class DbOtelYeniEntities : DbContext
    {
        public DbOtelYeniEntities()
            : base("name=DbOtelYeniEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblBirim> TblBirim { get; set; }
        public virtual DbSet<TblDepartman> TblDepartman { get; set; }
        public virtual DbSet<TblDurum> TblDurum { get; set; }
        public virtual DbSet<TblGorev> TblGorev { get; set; }
        public virtual DbSet<TblKasa> TblKasa { get; set; }
        public virtual DbSet<TblKur> TblKur { get; set; }
        public virtual DbSet<TblMisafir> TblMisafir { get; set; }
        public virtual DbSet<TblOda> TblOda { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
        public virtual DbSet<TblTelefon> TblTelefon { get; set; }
        public virtual DbSet<TblUlke> TblUlke { get; set; }
        public virtual DbSet<TblUrun> TblUrun { get; set; }
        public virtual DbSet<TblUrunGrup> TblUrunGrup { get; set; }
        public virtual DbSet<ilceler> ilceler { get; set; }
        public virtual DbSet<iller> iller { get; set; }
        public virtual DbSet<TblUrunHareket> TblUrunHareket { get; set; }
        public virtual DbSet<TblRezervasyon> TblRezervasyon { get; set; }
        public virtual DbSet<TblYeniKayit> TblYeniKayit { get; set; }
        public virtual DbSet<TblOnRezervasyon> TblOnRezervasyon { get; set; }
        public virtual DbSet<TblEkibimiz> TblEkibimiz { get; set; }
        public virtual DbSet<Tbliletisim> Tbliletisim { get; set; }
        public virtual DbSet<TblMesaj> TblMesaj { get; set; }
        public virtual DbSet<TblMesaj2> TblMesaj2 { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblKasaHareketi> TblKasaHareketi { get; set; }
        public virtual DbSet<TblKasaCikisHareketi> TblKasaCikisHareketi { get; set; }

        public virtual ObjectResult<OdaDurum_Result> OdaDurum()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OdaDurum_Result>("OdaDurum");
        }
    }
}
