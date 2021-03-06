/****** Object:  Table [dbo].[yn]    Script Date: 2017/05/15 星期一 19:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[yn](
	[songid] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
	[pinyin] [nvarchar](50) NULL,
	[singerName] [nvarchar](50) NULL,
	[type] [varchar](50) NULL,
	[hit] [int] NULL,
	[URL] [nvarchar](500) NULL,
	[SPURL] [nvarchar](500) NULL,
	[LrcLink] [varchar](500) NULL,
 CONSTRAINT [PK_yn] PRIMARY KEY CLUSTERED 
(
	[songid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[yn] ON 

INSERT [dbo].[yn] ([songid], [title], [pinyin], [singerName], [type], [hit], [URL], [SPURL], [LrcLink]) VALUES (1, N'三生三世', N'sanshengsanshi', N'黄仁烁,张杰', N'0', 0, N'http://120.26.134.162:8002/music/1.mp3', NULL, N'http://s.gecimi.com/lrc/177/17703/1770381.lrc')
INSERT [dbo].[yn] ([songid], [title], [pinyin], [singerName], [type], [hit], [URL], [SPURL], [LrcLink]) VALUES (2, N'突然好想你', N'turanhaoxiangni', N'五月天', N'0', 0, N'http://120.26.134.162:8002/music/2.mp3', NULL, N'http://s.gecimi.com/lrc/390/39042/3904220.lrc')
INSERT [dbo].[yn] ([songid], [title], [pinyin], [singerName], [type], [hit], [URL], [SPURL], [LrcLink]) VALUES (3, N'思念是一种病', N'sininashiyizhongbing', N'张震岳', N'0', 0, N'3.mp3', N'v3.mp4', N'http://s.gecimi.com/lrc/379/37954/3795456.lrc')
INSERT [dbo].[yn] ([songid], [title], [pinyin], [singerName], [type], [hit], [URL], [SPURL], [LrcLink]) VALUES (4, N'漂洋过海来看你', N'pyghlkn', N'朱亚文;王丽坤', N'0', 1, N'4.mp3', NULL, N'http://s.gecimi.com/lrc/382/38206/3820677.lrc')
SET IDENTITY_INSERT [dbo].[yn] OFF
