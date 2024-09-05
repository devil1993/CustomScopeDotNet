namespace BusinessLogics
{
    public interface ITenantDataAccess
    {
        TenantInfo GetCurrentTenantInformation();
    }
}