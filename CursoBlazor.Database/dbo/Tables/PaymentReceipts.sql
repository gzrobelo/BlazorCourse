CREATE TABLE [dbo].[PaymentReceipts](
	[Id] [uniqueidentifier] NOT NULL,
	[Invoice] [varchar](20) NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_PaymentReceipts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PaymentReceipts]  WITH CHECK ADD  CONSTRAINT [FK_PaymentReceipts_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO

ALTER TABLE [dbo].[PaymentReceipts] CHECK CONSTRAINT [FK_PaymentReceipts_Students]