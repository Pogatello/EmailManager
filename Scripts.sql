USE [EmailManagerDb]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[From] [nvarchar](max) NOT NULL,
	[To] [nvarchar](max) NOT NULL,
	[CC] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NOT NULL,
	[Priority] [int] NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



-----------------------------------------------------------------------------


  Insert into [EmailManagerDb].[dbo].[Messages]
  (
		[From]
      ,[To]
      ,[CC]
      ,[Subject]
      ,[Priority]
      ,[Content]
  )
  Values
  (
	'hrvoje.horvat@test.hr',
	'ivan.ivic@test.hr',
	null,
	'Test Email Sample 1',
	1,
	'The best way to show the importance of image rendering is to compare two emails that seem identical:'
  );

    Insert into [EmailManagerDb].[dbo].[Messages]
  (
		[From]
      ,[To]
      ,[CC]
      ,[Subject]
      ,[Priority]
      ,[Content]
  )
  Values
  (
	'marko.marko@test.hr',
	'ivan.ivic@test.hr',
	null,
	'Email Deliverability',
	1,
	'From above, another thing to pay attention to is deliverability and ways to avoid getting emails into spam. No one wants to spend a lot of time crafting a perfect email but never gets it delivered or opened. '
  );

      Insert into [EmailManagerDb].[dbo].[Messages]
  (
		[From]
      ,[To]
      ,[CC]
      ,[Subject]
      ,[Priority]
      ,[Content]
  )
  Values
  (
	'ivana.ivana@test.hr',
	'josip.ivic@test.hr',
	null,
	'Example of spam test',
	1,
	'It is true that you can check the above elements on your own but doing it with special tools doing spam testing and blacklisting analysis will have a better result. All your emails will be then sent to spam filters and a spam score. '
  );

        Insert into [EmailManagerDb].[dbo].[Messages]
  (
		[From]
      ,[To]
      ,[CC]
      ,[Subject]
      ,[Priority]
      ,[Content]
  )
  Values
  (
	'luka@test.hr',
	'test@test.hr',
	null,
	'Email Copy and Links',
	1,
	'The last but very important two elements to check before hitting the send button are email copy and inserted links. Many marketers and small business owners pay much attention to it, which is totally good. You must test links and email copy. However, don’t emphasize analyzing only these elements since, as you see from above, the tech aspects of emails are critical. '
  );