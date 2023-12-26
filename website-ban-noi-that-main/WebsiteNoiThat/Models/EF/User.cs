namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Users")]
    public partial class User
    {
        public int UserId { get; set; }

        [StringLength(50)]
        [DisplayName("Tên")]
        public string Name { get; set; }

        [StringLength(100)]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [DisplayName("Số điện thoại")]
        public int? Phone { get; set; }

        [StringLength(50)]
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }

        [StringLength(50)]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(50)]
        [DisplayName("Nhóm người dùng")]
        public string GroupId { get; set; }

        [DisplayName("Trạng thái tài khoản")]
        public bool Status { get; set; }
    }
}
