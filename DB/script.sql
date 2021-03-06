SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_role](
	[ROLEID] [int] IDENTITY(1,1) NOT NULL,
	[ROLENAME] [nvarchar](50) NULL,
	[ROLERIGHT] [nvarchar](50) NULL,
	[ISADMIN] [bit] NULL,
 CONSTRAINT [PK_tb_role] PRIMARY KEY CLUSTERED 
(
	[ROLEID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_role', N'COLUMN',N'ROLERIGHT'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_role', @level2type=N'COLUMN',@level2name=N'ROLERIGHT'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_department]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_department](
	[DEPID] [int] IDENTITY(1,1) NOT NULL,
	[DEPNAME] [nvarchar](100) NULL,
	[DEPPARID] [int] NULL,
	[DEPSORT] [int] NULL,
 CONSTRAINT [PK_tb_department] PRIMARY KEY CLUSTERED 
(
	[DEPID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_department', N'COLUMN',N'DEPPARID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上级部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_department', @level2type=N'COLUMN',@level2name=N'DEPPARID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_department', N'COLUMN',N'DEPSORT'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_department', @level2type=N'COLUMN',@level2name=N'DEPSORT'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_business]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_business](
	[BUSID] [int] IDENTITY(1,1) NOT NULL,
	[BUSNAME] [nvarchar](100) NULL,
	[BUSPRICE] [nvarchar](50) NULL,
	[BUSDETAILS] [nvarchar](500) NULL,
	[DEPID] [int] NULL,
 CONSTRAINT [PK_tb_business] PRIMARY KEY CLUSTERED 
(
	[BUSID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_business', N'COLUMN',N'BUSNAME'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'业务名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_business', @level2type=N'COLUMN',@level2name=N'BUSNAME'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_business', N'COLUMN',N'BUSPRICE'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_business', @level2type=N'COLUMN',@level2name=N'BUSPRICE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_business', N'COLUMN',N'BUSDETAILS'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'业务描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_business', @level2type=N'COLUMN',@level2name=N'BUSDETAILS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_business', N'COLUMN',N'DEPID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_business', @level2type=N'COLUMN',@level2name=N'DEPID'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_order](
	[ORDERID] [int] IDENTITY(1,1) NOT NULL,
	[ORDERNO] [nvarchar](100) NULL,
	[ORDERTIME] [datetime] NULL,
	[BUSID] [int] NULL,
	[ORDERPRICE] [nvarchar](50) NULL,
	[USERID] [int] NULL,
 CONSTRAINT [PK_tb_order] PRIMARY KEY CLUSTERED 
(
	[ORDERID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_order', N'COLUMN',N'BUSID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属业务' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_order', @level2type=N'COLUMN',@level2name=N'BUSID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_order', N'COLUMN',N'ORDERPRICE'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_order', @level2type=N'COLUMN',@level2name=N'ORDERPRICE'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_tuikuan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_tuikuan](
	[TUIKUANID] [int] IDENTITY(1,1) NOT NULL,
	[ORDERNO] [nvarchar](50) NULL,
	[TUIKPRICE] [nvarchar](50) NULL,
	[REASON] [nvarchar](4000) NULL,
	[REMARK] [nvarchar](400) NULL,
	[STATUS] [int] NULL,
	[APPLYTIME] [datetime] NULL,
	[REVIEWTIME] [datetime] NULL,
	[USERID] [int] NULL,
 CONSTRAINT [PK_tb_tuikuan] PRIMARY KEY CLUSTERED 
(
	[TUIKUANID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_tuikuan', N'COLUMN',N'ORDERNO'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'订单唯一编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_tuikuan', @level2type=N'COLUMN',@level2name=N'ORDERNO'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_tuikuan', N'COLUMN',N'TUIKPRICE'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'退款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_tuikuan', @level2type=N'COLUMN',@level2name=N'TUIKPRICE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_tuikuan', N'COLUMN',N'REASON'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'退款理由' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_tuikuan', @level2type=N'COLUMN',@level2name=N'REASON'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_tuikuan', N'COLUMN',N'REMARK'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'拒绝理由' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_tuikuan', @level2type=N'COLUMN',@level2name=N'REMARK'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_tuikuan', N'COLUMN',N'STATUS'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_tuikuan', @level2type=N'COLUMN',@level2name=N'STATUS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_tuikuan', N'COLUMN',N'APPLYTIME'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_tuikuan', @level2type=N'COLUMN',@level2name=N'APPLYTIME'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_tuikuan', N'COLUMN',N'REVIEWTIME'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'回复时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_tuikuan', @level2type=N'COLUMN',@level2name=N'REVIEWTIME'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_navigation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_navigation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nav_type] [nvarchar](50) NULL DEFAULT (''),
	[name] [nvarchar](50) NULL DEFAULT (''),
	[title] [nvarchar](100) NULL DEFAULT (''),
	[sub_title] [nvarchar](100) NULL DEFAULT (''),
	[link_url] [nvarchar](255) NULL DEFAULT (''),
	[sort_id] [int] NULL DEFAULT ((99)),
	[is_lock] [tinyint] NULL DEFAULT ((0)),
	[remark] [nvarchar](500) NULL DEFAULT (''),
	[parent_id] [int] NULL DEFAULT ((0)),
	[class_list] [nvarchar](500) NULL DEFAULT (''),
	[class_layer] [int] NULL DEFAULT ((1)),
	[channel_id] [int] NULL DEFAULT ((0)),
	[action_type] [nvarchar](500) NULL DEFAULT (''),
	[is_sys] [tinyint] NULL DEFAULT ((0)),
 CONSTRAINT [PK_DT_NAVIGATION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_manager]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_manager](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_id] [int] NOT NULL,
	[role_type] [int] NULL DEFAULT ((2)),
	[user_name] [nvarchar](100) NULL,
	[password] [nvarchar](100) NULL,
	[salt] [nvarchar](20) NULL,
	[real_name] [nvarchar](50) NULL DEFAULT (''),
	[telephone] [nvarchar](30) NULL DEFAULT (''),
	[email] [nvarchar](30) NULL DEFAULT (''),
	[is_lock] [int] NULL DEFAULT ((0)),
	[add_time] [datetime] NULL DEFAULT (getdate()),
	[dep_id] [int] NULL,
 CONSTRAINT [PK_DT_MANAGER] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_manager_role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_manager_role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [nvarchar](100) NULL,
	[role_type] [tinyint] NULL,
	[is_sys] [tinyint] NULL DEFAULT ((0)),
 CONSTRAINT [PK_DT_MANAGER_ROLE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_manager_role_value]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_manager_role_value](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_id] [int] NULL,
	[nav_name] [nvarchar](100) NULL,
	[action_type] [nvarchar](50) NULL,
 CONSTRAINT [PK_DT_MANAGER_ROLE_VALUE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_user]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_user](
	[USERID] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME] [nvarchar](50) NULL,
	[USERPWD] [nvarchar](50) NULL,
	[USERSTATUS] [int] NULL,
	[USERTYPE] [int] NULL,
	[USERROLEID] [int] NULL,
	[USERREALNAME] [nvarchar](50) NULL,
	[USERSEX] [nvarchar](10) NULL,
	[USERADDRESS] [nvarchar](200) NULL,
	[USERCARD] [nvarchar](50) NULL,
	[USERPHONE] [nvarchar](50) NULL,
	[USEREMALL] [nvarchar](50) NULL,
	[USERQUESTION] [nvarchar](100) NULL,
	[USERANSWER] [nvarchar](100) NULL,
 CONSTRAINT [PK_tb_user] PRIMARY KEY CLUSTERED 
(
	[USERID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_user', N'COLUMN',N'USERSTATUS'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态 0 待审核 1 正常 2 禁用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_user', @level2type=N'COLUMN',@level2name=N'USERSTATUS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_user', N'COLUMN',N'USERTYPE'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型 0 注册用户 1系统用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_user', @level2type=N'COLUMN',@level2name=N'USERTYPE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_user', N'COLUMN',N'USERROLEID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_user', @level2type=N'COLUMN',@level2name=N'USERROLEID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'tb_user', N'COLUMN',N'USERREALNAME'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_user', @level2type=N'COLUMN',@level2name=N'USERREALNAME'
