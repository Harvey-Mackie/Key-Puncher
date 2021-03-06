USE [sql1702389]
GO
/****** Object:  Table [dbo].[ads]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ads](
	[adid] [int] IDENTITY(1,1) NOT NULL,
	[left_photo] [varbinary](max) NULL,
	[right_photo] [varbinary](max) NULL,
 CONSTRAINT [PK_ads] PRIMARY KEY CLUSTERED 
(
	[adid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[confirm]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[confirm](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[staffid] [int] NULL,
	[confirmed] [varchar](4) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[consumer]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consumer](
	[customerid] [int] NOT NULL,
	[forename] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[addrss] [varchar](50) NOT NULL,
	[vipstatus] [int] NOT NULL,
	[access] [varchar](5) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[paymentid] [int] NOT NULL,
	[adid] [int] NOT NULL,
 CONSTRAINT [PK_consumer_1] PRIMARY KEY CLUSTERED 
(
	[customerid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gameChoiceResult]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameChoiceResult](
	[choiceId] [int] NOT NULL,
	[eventDifficulty] [int] NOT NULL,
	[eventResult] [int] NOT NULL,
	[choiceOneR] [int] NULL,
	[choiceOneV] [int] NULL,
	[choiceTwoR] [int] NULL,
	[choiceTwoV] [int] NULL,
 CONSTRAINT [PK_gameChoiceResult] PRIMARY KEY CLUSTERED 
(
	[choiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gameChoices]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameChoices](
	[choiceId] [int] NOT NULL,
	[eventDifficulty] [int] NOT NULL,
	[choiceOneR] [int] NULL,
	[choiceOneV] [int] NULL,
	[choiceTwoR] [int] NULL,
	[choiceTwoV] [int] NULL,
 CONSTRAINT [PK_gameChoices] PRIMARY KEY CLUSTERED 
(
	[choiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gameEvents]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameEvents](
	[eventId] [int] NOT NULL,
	[eventText] [varchar](500) NULL,
	[eventFeedback] [varchar](300) NULL,
	[choiceOne] [varchar](100) NULL,
	[choiceTwo] [varchar](100) NULL,
	[choiceID] [int] NOT NULL,
 CONSTRAINT [PK_gameEvent] PRIMARY KEY CLUSTERED 
(
	[eventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gameLevel]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameLevel](
	[difficulty] [int] NOT NULL,
	[EventLevel] [int] NULL,
	[choiceOneR] [int] NULL,
	[choiceOneV] [int] NULL,
	[choiceTwoR] [int] NULL,
	[choiceTwoV] [int] NULL,
 CONSTRAINT [PK_gameLevel] PRIMARY KEY CLUSTERED 
(
	[difficulty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gameScores]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameScores](
	[scoreid] [int] NOT NULL,
	[scoreValue] [int] NULL,
	[username] [varchar](150) NULL,
 CONSTRAINT [PK_gameScores] PRIMARY KEY CLUSTERED 
(
	[scoreid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gameUsers]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameUsers](
	[userId] [int] NOT NULL,
	[username] [varchar](150) NULL,
	[password] [varchar](150) NULL,
	[admin] [bit] NULL,
 CONSTRAINT [PK_gameUser] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[productid] [int] NOT NULL,
	[customerid] [int] NOT NULL,
	[totalprice] [decimal](5, 2) NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[particularads]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[particularads](
	[customerid] [int] IDENTITY(1,1) NOT NULL,
	[adid] [int] NOT NULL,
	[preferences] [varchar](50) NULL,
	[avatar] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment](
	[paymentid] [int] IDENTITY(1,1) NOT NULL,
	[orderid] [int] NOT NULL,
	[cardno] [int] NULL,
	[securityno] [int] NULL,
	[paidamount] [int] NULL,
 CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED 
(
	[paymentid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[productid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](10) NULL,
	[manufacturerdetails] [varchar](10) NULL,
	[purchaseprice] [decimal](5, 2) NULL,
	[sellingprice] [decimal](5, 2) NULL,
	[descript] [varchar](300) NULL,
	[photo] [varbinary](max) NULL,
	[issuedate] [date] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[productid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staffs]    Script Date: 19/12/2018 16:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staffs](
	[staffid] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](10) NOT NULL,
	[forename] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[wage] [decimal](10, 2) NOT NULL,
	[addrss] [varchar](100) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_staffs] PRIMARY KEY CLUSTERED 
(
	[staffid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 19/12/2018 16:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[productid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](10) NULL,
	[quantity] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[confirm]  WITH CHECK ADD  CONSTRAINT [FK_confirm_orders] FOREIGN KEY([orderid])
REFERENCES [dbo].[orders] ([orderid])
GO
ALTER TABLE [dbo].[confirm] CHECK CONSTRAINT [FK_confirm_orders]
GO
ALTER TABLE [dbo].[confirm]  WITH CHECK ADD  CONSTRAINT [FK_confirm_staffs] FOREIGN KEY([staffid])
REFERENCES [dbo].[staffs] ([staffid])
GO
ALTER TABLE [dbo].[confirm] CHECK CONSTRAINT [FK_confirm_staffs]
GO
ALTER TABLE [dbo].[gameEvents]  WITH CHECK ADD  CONSTRAINT [FK_ChoiceLink] FOREIGN KEY([choiceID])
REFERENCES [dbo].[gameChoiceResult] ([choiceId])
GO
ALTER TABLE [dbo].[gameEvents] CHECK CONSTRAINT [FK_ChoiceLink]
GO
ALTER TABLE [dbo].[gameLevel]  WITH CHECK ADD  CONSTRAINT [FK_gameLevel_gameLevel] FOREIGN KEY([difficulty])
REFERENCES [dbo].[gameLevel] ([difficulty])
GO
ALTER TABLE [dbo].[gameLevel] CHECK CONSTRAINT [FK_gameLevel_gameLevel]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_consumer] FOREIGN KEY([customerid])
REFERENCES [dbo].[consumer] ([customerid])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_consumer]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_product] FOREIGN KEY([productid])
REFERENCES [dbo].[product] ([productid])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_product]
GO
ALTER TABLE [dbo].[particularads]  WITH CHECK ADD  CONSTRAINT [FK_ad_consumer_ads] FOREIGN KEY([adid])
REFERENCES [dbo].[ads] ([adid])
GO
ALTER TABLE [dbo].[particularads] CHECK CONSTRAINT [FK_ad_consumer_ads]
GO
ALTER TABLE [dbo].[particularads]  WITH CHECK ADD  CONSTRAINT [FK_ad_consumer_consumer] FOREIGN KEY([customerid])
REFERENCES [dbo].[consumer] ([customerid])
GO
ALTER TABLE [dbo].[particularads] CHECK CONSTRAINT [FK_ad_consumer_consumer]
GO
ALTER TABLE [dbo].[payment]  WITH CHECK ADD  CONSTRAINT [FK_payment_orders] FOREIGN KEY([orderid])
REFERENCES [dbo].[orders] ([orderid])
GO
ALTER TABLE [dbo].[payment] CHECK CONSTRAINT [FK_payment_orders]
GO
ALTER TABLE [dbo].[stock]  WITH CHECK ADD  CONSTRAINT [FK_stock_product] FOREIGN KEY([productid])
REFERENCES [dbo].[product] ([productid])
GO
ALTER TABLE [dbo].[stock] CHECK CONSTRAINT [FK_stock_product]
GO
