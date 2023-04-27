CREATE TABLE [dbo].[Courses](
	[CourseId] [uniqueidentifier] NOT NULL,
	[CourseKey] [nchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Hours] [int] NOT NULL,
	[Description] [varchar](250) NULL,
	[InstructorId] [uniqueidentifier] NOT NULL,
	[CareerId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Carrers] FOREIGN KEY([CareerId])
REFERENCES [dbo].[Careers] ([CareerId])
GO

ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Carrers]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Instructors] FOREIGN KEY([InstructorId])
REFERENCES [dbo].[Instructors] ([InstructorId])
GO

ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Instructors]