namespace Service.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DanhMuc_DbContext : DbContext
    {
        public DanhMuc_DbContext()
            : base("name=DanhMuc_DbContext")
        {
        }

        public virtual DbSet<DM_BannerType> DM_BannerType { get; set; }
        public virtual DbSet<DM_SliderType> DM_SliderType { get; set; }
        public virtual DbSet<ELMAH_Error> ELMAH_Error { get; set; }
        public virtual DbSet<M_NhucauPhuTai_DB_HA> M_NhucauPhuTai_DB_HA { get; set; }
        public virtual DbSet<M_SanLuongSXKD> M_SanLuongSXKD { get; set; }
        public virtual DbSet<MO_GiaThiTruong_HA1> MO_GiaThiTruong_HA1 { get; set; }
        public virtual DbSet<S_MienID> S_MienID { get; set; }
        public virtual DbSet<S_SanLuongSXKD> S_SanLuongSXKD { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
        public virtual DbSet<tblAdv> tblAdv { get; set; }
        public virtual DbSet<tblAlbum> tblAlbum { get; set; }
        public virtual DbSet<tblAlbums> tblAlbums { get; set; }
        public virtual DbSet<tblAlbumsCate> tblAlbumsCate { get; set; }
        public virtual DbSet<tblAnnounce> tblAnnounce { get; set; }
        public virtual DbSet<tblBanner> tblBanner { get; set; }
        public virtual DbSet<tblBrand> tblBrand { get; set; }
        public virtual DbSet<tblCartInfo> tblCartInfo { get; set; }
        public virtual DbSet<tblCateNews> tblCateNews { get; set; }
        public virtual DbSet<tblCateNewsGroup> tblCateNewsGroup { get; set; }
        public virtual DbSet<tblCateProduct> tblCateProduct { get; set; }
        public virtual DbSet<tblCompany> tblCompany { get; set; }
        public virtual DbSet<tblConfig> tblConfig { get; set; }
        public virtual DbSet<tblContactSlider> tblContactSlider { get; set; }
        public virtual DbSet<tblChart24h> tblChart24h { get; set; }
        public virtual DbSet<tblChartRound> tblChartRound { get; set; }
        public virtual DbSet<tblDownload> tblDownload { get; set; }
        public virtual DbSet<tblFaq> tblFaq { get; set; }
        public virtual DbSet<tblLogDeleteNews> tblLogDeleteNews { get; set; }
        public virtual DbSet<tblLogDeleteOfficial> tblLogDeleteOfficial { get; set; }
        public virtual DbSet<tblLogDeleteOfficialFile> tblLogDeleteOfficialFile { get; set; }
        public virtual DbSet<tblMember> tblMember { get; set; }
        public virtual DbSet<tblMenuLinks> tblMenuLinks { get; set; }
        public virtual DbSet<tblModules> tblModules { get; set; }
        public virtual DbSet<tblModulesFrontPanel> tblModulesFrontPanel { get; set; }
        public virtual DbSet<tblNews> tblNews { get; set; }
        public virtual DbSet<tblNewsGroup> tblNewsGroup { get; set; }
        public virtual DbSet<tblOfficial> tblOfficial { get; set; }
        public virtual DbSet<tblOfficialFile> tblOfficialFile { get; set; }
        public virtual DbSet<tblOrder> tblOrder { get; set; }
        public virtual DbSet<tblOrderDetail> tblOrderDetail { get; set; }
        public virtual DbSet<tblPage> tblPage { get; set; }
        public virtual DbSet<tblPermission> tblPermission { get; set; }
        public virtual DbSet<tblPicture> tblPicture { get; set; }
        public virtual DbSet<tblProduct> tblProduct { get; set; }
        public virtual DbSet<tblPhoneBook> tblPhoneBook { get; set; }
        public virtual DbSet<tblQuestion> tblQuestion { get; set; }
        public virtual DbSet<tblRelation> tblRelation { get; set; }
        public virtual DbSet<tblRoles> tblRoles { get; set; }
        public virtual DbSet<tblRSS> tblRSS { get; set; }
        public virtual DbSet<tblShortURL> tblShortURL { get; set; }
        public virtual DbSet<tblSinglePage> tblSinglePage { get; set; }
        public virtual DbSet<tblTax> tblTax { get; set; }
        public virtual DbSet<tblTopSlider> tblTopSlider { get; set; }
        public virtual DbSet<tblVideo> tblVideo { get; set; }
        public virtual DbSet<tblAdminRoles> tblAdminRoles { get; set; }
        public virtual DbSet<tblBook> tblBook { get; set; }
        public virtual DbSet<tblCateNewsPermission> tblCateNewsPermission { get; set; }
        public virtual DbSet<tblContact> tblContact { get; set; }
        public virtual DbSet<tblEmail> tblEmail { get; set; }
        public virtual DbSet<tblLink> tblLink { get; set; }
        public virtual DbSet<tblNewsComment> tblNewsComment { get; set; }
        public virtual DbSet<tblPageComment> tblPageComment { get; set; }
        public virtual DbSet<tblProductComment> tblProductComment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DM_BannerType>()
                .HasMany(e => e.tblBanner)
                .WithRequired(e => e.DM_BannerType)
                .HasForeignKey(e => e.BannerTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DM_SliderType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat1)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat2)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat3)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat4)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat5)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat6)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat7)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat8)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat9)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat10)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat11)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat12)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat13)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat14)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat15)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat16)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat17)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat18)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat19)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat20)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat21)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat22)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat23)
                .HasPrecision(18, 8);

            modelBuilder.Entity<M_NhucauPhuTai_DB_HA>()
                .Property(e => e.Congsuat24)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia1)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia2)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia3)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia4)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia5)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia6)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia7)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia8)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia9)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia10)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia11)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia12)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia13)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia14)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia15)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia16)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia17)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia18)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia19)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia20)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia21)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia22)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia23)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MO_GiaThiTruong_HA1>()
                .Property(e => e.Gia24)
                .HasPrecision(18, 8);

            modelBuilder.Entity<S_MienID>()
                .Property(e => e.TenMien)
                .IsFixedLength();

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_Username)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_Password)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_Permission)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_NickYahoo)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_NickSkype)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.Admin_Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdv>()
                .Property(e => e.AdvImage)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbum>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbum>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbums>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbums>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbums>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbums>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbumsCate>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbumsCate>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblAlbumsCate>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAnnounce>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblAnnounce>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAnnounce>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblAnnounce>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAnnounce>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblBanner>()
                .Property(e => e.Url)
                .IsFixedLength();

            modelBuilder.Entity<tblBanner>()
                .Property(e => e.ColorText)
                .IsFixedLength();

            modelBuilder.Entity<tblBanner>()
                .Property(e => e.ColorBG)
                .IsFixedLength();

            modelBuilder.Entity<tblBanner>()
                .HasMany(e => e.tblContactSlider)
                .WithRequired(e => e.tblBanner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBrand>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<tblBrand>()
                .Property(e => e.BrandUrl)
                .IsUnicode(false);

            modelBuilder.Entity<tblBrand>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblCartInfo>()
                .Property(e => e.OrderID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tblCateNews>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNews>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNews>()
                .Property(e => e.Roles)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNews>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNews>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNews>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNewsGroup>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNewsGroup>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateProduct>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateProduct>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<tblCompany>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblCompany>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblCompany>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.language)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.titleweb)
                .IsFixedLength();

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.google)
                .IsFixedLength();

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.new_icon_w)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.new_icon_h)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.new_thumb_w)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.new_thumb_h)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.new_large_w)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.new_large_h)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.product_icon_w)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.product_icon_h)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.product_thumb_w)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.product_thumb_h)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.product_large_w)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.product_large_h)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.productNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.productNoPage)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.currency)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.WebServerIP)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.WebMailServer)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfig>()
                .Property(e => e.WebDomain)
                .IsUnicode(false);

            modelBuilder.Entity<tblDownload>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblDownload>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblDownload>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblDownload>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblDownload>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblFaq>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblMember>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblMember>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tblMember>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblMember>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblMember>()
                .Property(e => e.NickYahoo)
                .IsUnicode(false);

            modelBuilder.Entity<tblMember>()
                .Property(e => e.NickSkype)
                .IsUnicode(false);

            modelBuilder.Entity<tblMember>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<tblMenuLinks>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<tblModulesFrontPanel>()
                .Property(e => e.ModulesFrontPanel_Panel)
                .IsUnicode(false);

            modelBuilder.Entity<tblModulesFrontPanel>()
                .Property(e => e.language)
                .IsUnicode(false);

            modelBuilder.Entity<tblNews>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblNews>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblNews>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblNews>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblNews>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblNewsGroup>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblNewsGroup>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblNewsGroup>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblNewsGroup>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblNewsGroup>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblNewsGroup>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblOfficial>()
                .Property(e => e.Attached)
                .IsUnicode(false);

            modelBuilder.Entity<tblOfficial>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblOfficial>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblOfficialFile>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.NickYahoo)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.NickSkype)
                .IsUnicode(false);

            modelBuilder.Entity<tblPage>()
                .Property(e => e.Imagethumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblPage>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblPage>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<tblPage>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPage>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPermission>()
                .Property(e => e.PermissionName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPermission>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<tblPicture>()
                .Property(e => e.PictureThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblPicture>()
                .Property(e => e.PictureLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblQuestion>()
                .Property(e => e.Question_FileAttach)
                .IsUnicode(false);

            modelBuilder.Entity<tblQuestion>()
                .Property(e => e.Question_Image)
                .IsUnicode(false);

            modelBuilder.Entity<tblQuestion>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblQuestion>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblRelation>()
                .Property(e => e.ImageThumb)
                .IsUnicode(false);

            modelBuilder.Entity<tblRelation>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<tblRelation>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblRoles>()
                .Property(e => e.Roles_Modules)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSS>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSS>()
                .Property(e => e.RSSUrl)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSS>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<tblShortURL>()
                .Property(e => e.LongURL)
                .IsFixedLength();

            modelBuilder.Entity<tblShortURL>()
                .Property(e => e.ShortURL)
                .IsFixedLength();

            modelBuilder.Entity<tblShortURL>()
                .Property(e => e.Title)
                .IsFixedLength();

            modelBuilder.Entity<tblSinglePage>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<tblSinglePage>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblSinglePage>()
                .Property(e => e.CreatedUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblVideo>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<tblVideo>()
                .Property(e => e.VideoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<tblVideo>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblVideo>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdminRoles>()
                .Property(e => e.Admin_UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdminRoles>()
                .Property(e => e.Permission)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdminRoles>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblBook>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblBook>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNewsPermission>()
                .Property(e => e.Permission)
                .IsUnicode(false);

            modelBuilder.Entity<tblCateNewsPermission>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Attact)
                .IsUnicode(false);

            modelBuilder.Entity<tblLink>()
                .Property(e => e.LinkImage)
                .IsUnicode(false);

            modelBuilder.Entity<tblNewsComment>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPageComment>()
                .Property(e => e.GroupCate)
                .IsUnicode(false);

            modelBuilder.Entity<tblPageComment>()
                .Property(e => e.ApprovalUserName)
                .IsUnicode(false);
        }
    }
}
