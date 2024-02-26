public ExoContext()
{
}
O references
public ExoContext(DbContextOptions<ExoContext> options) : base(options)
{
}
protected override void OnConfiguring (DbContextOptionsBuilder options Builder)
{ 

if(!optionsBuilder. IsConfigured)
{
// Essa string de conexão foi depende da SUA máquina.
options Builder. UseSqlServer("Server-localhost\\SQLEXPRES01; "
+ "Database ExoApi; Trusted_Connection=True;");

// Exemplo 1 de string de conexão:
// User ID=sa; Password=admin; Server-localhost; Database=ExoApi;-
// + Trusted_Connection=False;

// Exemplo 2 de string de conexão:
// Server=localhost\\SQLEXPRESS; Database=ExoApi; Trusted_Connection=True;
    }
}