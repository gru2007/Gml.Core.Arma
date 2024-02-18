using SQLite;

namespace Gml.Models.Storage
{
    public class StorageItem
    {
        [PrimaryKey] public string Key { get; set; } = null!;
        public string? TypeName { get; set; }
        public string Value { get; set; } = null!;
    }

    public class UserStorageItem
    {
        [PrimaryKey] public string Login { get; set; } = null!;
        public string? TypeName { get; set; }
        public string Value { get; set; } = null!;
    }
}
