using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.DBContext
{
    public class DBBookStoreContext : DbContext
    {
        public DBBookStoreContext(DbContextOptions<DBBookStoreContext> options) : base(options) { }

        public DbSet<Staff> staffs { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Publisher> publishers { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<BookReceipt> bookreceipts { get; set; }
        public DbSet<BookInvoice> bookinvoices { get; set; }
        public DbSet<BookInvoiceDetail> bookinvoicedetails { get; set; }
        public DbSet<BookReceiptDetail> bookreceiptsdetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(s => s.id);
                entity.Property(s => s.id).ValueGeneratedNever();

                entity.Property(s => s.fullname).IsRequired();
                entity.Property(s => s.birthday).IsRequired();
                entity.Property(s => s.identification).IsRequired();
                entity.Property(s => s.phonenumber).IsRequired();
                entity.Property(s => s.addre).IsRequired();
                entity.Property(s => s.workschedule).IsRequired();

                entity.HasOne(s => s.account)
                .WithOne(a => a.staff)
                .HasForeignKey<Account>(a => a.idstaff);

                entity.HasMany(s => s.bookreceipts)
                .WithOne(br => br.staff)
                .HasForeignKey(br => br.idstaff);

                entity.HasMany(s => s.bookinvoices)
                .WithOne(bi => bi.staff)
                .HasForeignKey(bi => bi.idstaff);
            }
            );

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(a => a.username);

                entity.Property(a => a.passw).IsRequired();
                entity.Property(a => a.roleacc).IsRequired();
                entity.Property(a => a.idstaff).IsRequired();

                entity.HasOne(a => a.staff)
                .WithOne(s => s.account)
                .HasForeignKey<Account>(a => a.idstaff);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.id);

                entity.Property(c => c.namecategory).IsRequired();

                entity.HasMany(c => c.books)
                .WithOne(b => b.category)
                .HasForeignKey(b => b.idcate);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(a => a.id);

                entity.Property(a => a.fullname).IsRequired();
                entity.Property(a => a.addre).IsRequired();

                entity.HasMany(a => a.books)
                .WithOne(b => b.author)
                .HasForeignKey(b => b.idau);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(p => p.id);

                entity.Property(p => p.namepublisher).IsRequired();
                entity.Property(p => p.phonenumber).IsRequired();
                entity.Property(p => p.addre).IsRequired();

                entity.HasMany(p => p.books)
                .WithOne(b => b.publisher)
                .HasForeignKey(b => b.idpub);

                entity.HasMany(p => p.bookreceipts)
                .WithOne(br => br.publisher)
                .HasForeignKey(br => br.idpublisher);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.id);

                entity.Property(e => e.namebook).IsRequired();
                entity.Property(e => e.quanlitystock).IsRequired();
                entity.Property(e => e.importprice).IsRequired();
                entity.Property(e => e.retailprice).IsRequired();
                entity.Property(e => e.idcate).IsRequired();
                entity.Property(e => e.idau).IsRequired();
                entity.Property(e => e.idpub).IsRequired();

                entity.HasOne(b => b.category)
                .WithMany(c => c.books)
                .HasForeignKey(b => b.idcate);

                entity.HasOne(b => b.author)
                .WithMany(a => a.books)
                .HasForeignKey(b => b.idau);

                entity.HasOne(b => b.publisher)
                .WithMany(p => p.books)
                .HasForeignKey(b => b.idpub);

                entity.HasOne(b => b.bookinvoicedetail)
                .WithOne(bid => bid.book)
                .HasForeignKey<BookInvoiceDetail>(bid => bid.idbook);

                entity.HasOne(b => b.bookreceiptdetail)
                .WithOne(brd => brd.book)
                .HasForeignKey<BookReceiptDetail>(brd => brd.idbook);
            }
            );

            modelBuilder.Entity<BookReceipt>(entity =>
            {
                entity.HasKey(br => br.id);

                entity.Property(br => br.dateentry).IsRequired();
                entity.Property(br => br.idpublisher).IsRequired();
                entity.Property(br => br.idstaff).IsRequired();
                entity.Property(br => br.totalprice).IsRequired();

                entity.HasOne(br => br.publisher)
                .WithMany(p => p.bookreceipts)
                .HasForeignKey(br => br.idpublisher);

                entity.HasOne(br => br.staff)
                .WithMany(s => s.bookreceipts)
                .HasForeignKey(br => br.idstaff);

                entity.HasMany(br => br.bookreceiptsdetalls)
                .WithOne(brd => brd.bookreceipt)
                .HasForeignKey(brd => brd.idreceipt);

            });

            modelBuilder.Entity<BookInvoice>(entity =>
            {
                entity.HasKey(bi => bi.id);

                entity.Property(bi => bi.saledate).IsRequired();
                entity.Property(bi => bi.idstaff).IsRequired();
                entity.Property(bi => bi.totalprice).IsRequired();

                entity.HasOne(bi => bi.staff)
                .WithMany(s => s.bookinvoices)
                .HasForeignKey(bi => bi.idstaff);

                entity.HasMany(bi => bi.bookinvoicedetails)
                .WithOne(bid => bid.bookinvoice)
                .HasForeignKey(bid => bid.idinvoice);
            });

            modelBuilder.Entity<BookInvoiceDetail>(entity =>
            {
                entity.HasKey(bid => new { bid.idinvoice, bid.idbook });

                entity.Property(bid => bid.quanlity).IsRequired();
                entity.Property(bid => bid.totalprice).IsRequired();

                entity.HasOne(bid => bid.bookinvoice)
                .WithMany(bi => bi.bookinvoicedetails)
                .HasForeignKey(bi => bi.idinvoice);

                entity.HasOne(bid => bid.book)
                .WithOne(b => b.bookinvoicedetail)
                .HasForeignKey<BookInvoiceDetail>(bid => bid.idbook);
            });

            modelBuilder.Entity<BookReceiptDetail>(entity =>
            {
                entity.HasKey(brd => new { brd.idreceipt, brd.idbook });

                entity.Property(brd => brd.quanlity).IsRequired();
                entity.Property(brd => brd.totalprice).IsRequired();

                entity.HasOne(brd => brd.bookreceipt)
                .WithMany(br => br.bookreceiptsdetalls)
                .HasForeignKey(brd => brd.idreceipt);

                entity.HasOne(brd => brd.book)
                .WithOne(b => b.bookreceiptdetail)
                .HasForeignKey<BookReceiptDetail>(brd => brd.idbook);
            });
        }
    }
}
