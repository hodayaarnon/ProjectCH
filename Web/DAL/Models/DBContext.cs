using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addcommunity> Addcommunity { get; set; }
        public virtual DbSet<Askstojoin> Askstojoin { get; set; }
        public virtual DbSet<Authorizations> Authorizations { get; set; }
        public virtual DbSet<Communities> Communities { get; set; }
        public virtual DbSet<Joinings> Joinings { get; set; }
        public virtual DbSet<Places> Places { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<Takingsuggestions> Takingsuggestions { get; set; }
        public virtual DbSet<Transports> Transports { get; set; }
        public virtual DbSet<Transportstates> Transportstates { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID=transportsdb;Password=Lq1f7C-BGo~N");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addcommunity>(entity =>
            {
                entity.HasKey(e => e.Addid)
                    .HasName("PK__addcommu__CDFEBCBAD5FB8A30");

                entity.ToTable("addcommunity");

                entity.Property(e => e.Addid).HasColumnName("addid");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Communityname)
                    .HasColumnName("communityname")
                    .HasMaxLength(50);

                entity.Property(e => e.Descriptions)
                    .HasColumnName("descriptions")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("pictureUrl")
                    .HasMaxLength(100);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Addcommunity)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__addcommun__useri__361203C5");
            });

            modelBuilder.Entity<Askstojoin>(entity =>
            {
                entity.HasKey(e => e.Askid)
                    .HasName("PK__askstojo__0B302AD48AE0764D");

                entity.ToTable("askstojoin");

                entity.Property(e => e.Askid).HasColumnName("askid");

                entity.Property(e => e.Communityid).HasColumnName("communityid");

                entity.Property(e => e.Joinasamanager)
                    .HasColumnName("joinasamanager")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Askstojoin)
                    .HasForeignKey(d => d.Communityid)
                    .HasConstraintName("FK__askstojoi__commu__324172E1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Askstojoin)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__askstojoi__useri__314D4EA8");
            });

            modelBuilder.Entity<Authorizations>(entity =>
            {
                entity.HasKey(e => new { e.Communityid, e.Roleid })
                    .HasName("PK__authoriz__AF5BA8EA4317669D");

                entity.ToTable("authorizations");

                entity.Property(e => e.Communityid).HasColumnName("communityid");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.Communityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__authoriza__commu__2C88998B");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__authoriza__rolei__2D7CBDC4");
            });

            modelBuilder.Entity<Communities>(entity =>
            {
                entity.HasKey(e => e.Communityid)
                    .HasName("PK__communit__93823C552B7C71F4");

                entity.ToTable("communities");

                entity.Property(e => e.Communityid).HasColumnName("communityid");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Communityname)
                    .IsRequired()
                    .HasColumnName("communityname")
                    .HasMaxLength(50);

                entity.Property(e => e.Descriptions)
                    .HasColumnName("descriptions")
                    .HasMaxLength(50);

                entity.Property(e => e.Primemanager).HasColumnName("primemanager");

                entity.Property(e => e.Requiredpremit).HasColumnName("requiredpremit");

                entity.HasOne(d => d.PrimemanagerNavigation)
                    .WithMany(p => p.Communities)
                    .HasForeignKey(d => d.Primemanager)
                    .HasConstraintName("FK__communiti__prime__10E07F16");
            });

            modelBuilder.Entity<Joinings>(entity =>
            {
                entity.HasKey(e => e.Joiningid)
                    .HasName("PK__joinings__DE1269BB670CD7FD");

                entity.ToTable("joinings");

                entity.Property(e => e.Joiningid).HasColumnName("joiningid");

                entity.Property(e => e.Communityid).HasColumnName("communityid");

                entity.Property(e => e.Isavalid).HasColumnName("isavalid");

                entity.Property(e => e.Joinnigdate)
                    .HasColumnName("joinnigdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Joinings)
                    .HasForeignKey(d => d.Communityid)
                    .HasConstraintName("FK__joinings__commun__27C3E46E");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Joinings)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK__joinings__roleid__28B808A7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Joinings)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__joinings__userid__26CFC035");
            });

            modelBuilder.Entity<Places>(entity =>
            {
                entity.HasKey(e => e.Placeid)
                    .HasName("PK__places__E12066DE7E9A40CC");

                entity.ToTable("places");

                entity.Property(e => e.Placeid).HasColumnName("placeid");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasMaxLength(50);

                entity.Property(e => e.Adresslat).HasColumnName("adresslat");

                entity.Property(e => e.Adresslng).HasColumnName("adresslng");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20);

                entity.Property(e => e.Contactphone)
                    .HasColumnName("contactphone")
                    .HasMaxLength(50);

                entity.Property(e => e.Housenumber)
                    .HasColumnName("housenumber")
                    .HasMaxLength(10);

                entity.Property(e => e.Placedescription)
                    .HasColumnName("placedescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("PK__roles__CD994BF225E9ABB5");

                entity.ToTable("roles");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Rolename)
                    .HasColumnName("rolename")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Statuses>(entity =>
            {
                entity.HasKey(e => e.Statusid)
                    .HasName("PK__statuses__36247E3033AC2F62");

                entity.ToTable("statuses");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.Descriptions)
                    .HasColumnName("descriptions")
                    .HasMaxLength(50);

                entity.Property(e => e.Statusname)
                    .HasColumnName("statusname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Takingsuggestions>(entity =>
            {
                entity.HasKey(e => e.Askid)
                    .HasName("PK__takingsu__0B302AD4CB6B4691");

                entity.ToTable("takingsuggestions");

                entity.Property(e => e.Askid).HasColumnName("askid");

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Estimatedarrivaltime)
                    .HasColumnName("estimatedarrivaltime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Relevant).HasColumnName("relevant");

                entity.Property(e => e.Transportid).HasColumnName("transportid");

                entity.Property(e => e.Volunteerid).HasColumnName("volunteerid");

                entity.HasOne(d => d.Transport)
                    .WithMany(p => p.Takingsuggestions)
                    .HasForeignKey(d => d.Transportid)
                    .HasConstraintName("FK__takingsug__trans__39E294A9");

                entity.HasOne(d => d.Volunteer)
                    .WithMany(p => p.Takingsuggestions)
                    .HasForeignKey(d => d.Volunteerid)
                    .HasConstraintName("FK__takingsug__volun__38EE7070");
            });

            modelBuilder.Entity<Transports>(entity =>
            {
                entity.HasKey(e => e.Transportid)
                    .HasName("PK__transpor__59165AC7A948ECB2");

                entity.ToTable("transports");

                entity.Property(e => e.Transportid).HasColumnName("transportid");

                entity.Property(e => e.Arrive).HasColumnName("arrive");

                entity.Property(e => e.Beginlinetoexec)
                    .HasColumnName("beginlinetoexec")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Communityid).HasColumnName("communityid");

                entity.Property(e => e.Confirmedbymanager).HasColumnName("confirmedbymanager");

                entity.Property(e => e.Contentsdescription)
                    .HasColumnName("contentsdescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Deadlinetoexec)
                    .HasColumnName("deadlinetoexec")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destinationid).HasColumnName("destinationid");

                entity.Property(e => e.Estimatedarrivaltime)
                    .HasColumnName("estimatedarrivaltime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Foundvolunteer)
                    .HasColumnName("foundvolunteer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Instructions)
                    .HasColumnName("instructions")
                    .HasMaxLength(100);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.ManagerInstruction)
                    .HasColumnName("managerInstruction")
                    .HasMaxLength(50);

                entity.Property(e => e.Packagesize)
                    .HasColumnName("packagesize")
                    .HasMaxLength(20);

                entity.Property(e => e.Packageweight).HasColumnName("packageweight");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Volunteerid).HasColumnName("volunteerid");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Transports)
                    .HasForeignKey(d => d.Communityid)
                    .HasConstraintName("FK__transport__commu__14B10FFA");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.TransportsDestination)
                    .HasForeignKey(d => d.Destinationid)
                    .HasConstraintName("FK__transport__desti__1975C517");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.TransportsSource)
                    .HasForeignKey(d => d.Sourceid)
                    .HasConstraintName("FK__transport__sourc__1881A0DE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TransportsUser)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__transport__useri__13BCEBC1");

                entity.HasOne(d => d.Volunteer)
                    .WithMany(p => p.TransportsVolunteer)
                    .HasForeignKey(d => d.Volunteerid)
                    .HasConstraintName("FK__transport__volun__178D7CA5");
            });

            modelBuilder.Entity<Transportstates>(entity =>
            {
                entity.HasKey(e => e.Stateid)
                    .HasName("PK__transpor__A666BDB91A8E17B2");

                entity.ToTable("transportstates");

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.Property(e => e.Statusenddate)
                    .HasColumnName("statusenddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusstrartdate)
                    .HasColumnName("statusstrartdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Transportid).HasColumnName("transportid");

                entity.Property(e => e.Transportstatus).HasColumnName("transportstatus");

                entity.HasOne(d => d.Transport)
                    .WithMany(p => p.Transportstates)
                    .HasForeignKey(d => d.Transportid)
                    .HasConstraintName("FK__transport__trans__3DB3258D");

                entity.HasOne(d => d.TransportstatusNavigation)
                    .WithMany(p => p.Transportstates)
                    .HasForeignKey(d => d.Transportstatus)
                    .HasConstraintName("FK__transport__trans__3EA749C6");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__users__CBA1B257A6B4FFFC");

                entity.ToTable("users");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasMaxLength(50);

                entity.Property(e => e.Adresslat).HasColumnName("adresslat");

                entity.Property(e => e.Adresslng).HasColumnName("adresslng");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Housenumber)
                    .HasColumnName("housenumber")
                    .HasMaxLength(10);

                entity.Property(e => e.Placeid).HasColumnName("placeid");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(20);

                entity.Property(e => e.Userfirstname)
                    .HasColumnName("userfirstname")
                    .HasMaxLength(20);

                entity.Property(e => e.Useridentity)
                    .HasColumnName("useridentity")
                    .HasMaxLength(20);

                entity.Property(e => e.Userlastname)
                    .HasColumnName("userlastname")
                    .HasMaxLength(20);

                entity.Property(e => e.Userpassword)
                    .HasColumnName("userpassword")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Placeid)
                    .HasConstraintName("FK__users__placeid__7FB5F314");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
