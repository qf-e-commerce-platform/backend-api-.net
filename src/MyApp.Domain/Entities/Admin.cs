using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Domain.Entities;

public class Admin
{
    /// <summary>
    /// 主键
    /// </summary>
    [Column("id")]
    public long Id { get; set; }
    
    /// <summary>
    /// 手机号
    /// </summary>
    [Column("mobile")]
    [Required]
    [MaxLength(30)]
    public required string Mobile { get; set; }
    
    /// <summary>
    /// 登录密码
    /// </summary>
    [Column("password_hash")]
    [Required]
    [MaxLength(100)]
    public required string Password { get; set; }
    
    /// <summary>
    /// 用户名称
    /// </summary>
    [Column("username")]
    [Required]
    [MaxLength(50)]
    public required string Username { get; set; }
    
    /// <summary>
    /// 真实姓名
    /// </summary>
    [Column("realname")]
    [MaxLength(50)]
    public string Realname { get; set; } = string.Empty;
    
    /// <summary>
    /// 邮箱
    /// </summary>
    [Column("email")]
    [MaxLength(50)]
    public string Email { get; set; } = string.Empty;
    
    /// <summary>
    /// 备注
    /// </summary>
    [Column("remark")]
    [MaxLength(300)]
    public string Remark { get; set; } = string.Empty;

    /// <summary>
    /// 状态:-2删除，-1禁用，0正常，2启用
    /// </summary>
    [Column("status")]
    public sbyte Status { get; set; } = 0;
    
    /// <summary>
    /// 是否已审核:0-未审核，1-已审核，-1-审核驳回
    /// </summary>
    [Column("is_auth")]
    public sbyte IsAuth { get; set; } = 0;
    
    /// <summary>
    /// 驳回原因
    /// </summary>
    [Column("reject_reason")]
    [MaxLength(100)]
    public string RejectReason { get; set; } = string.Empty;
    
    /// <summary>
    /// 上次登录时间
    /// </summary>
    [Column("last_login_time")]
    public DateTime? LastLoginTime { get; set; }
    
    /// <summary>
    /// 最后登录IP
    /// </summary>
    [Column("login_ip")]
    public string LoginIp { get; set; } = string.Empty;
    
    /// <summary>
    /// 初始化密码
    /// </summary>
    [Column("init_password")]
    [MaxLength(100)]
    public string InitPassword { get; set; } = string.Empty;
}