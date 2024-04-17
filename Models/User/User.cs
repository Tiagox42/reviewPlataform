using reviewPlataform.Models.User.Enums;

namespace reviewPlataform.Models.User
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Role Role { get; set; } = Role.Basic;
        public string? Picture { get; set; }

    }
}
