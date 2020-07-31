# Product-app
# Clone : git clone
# Open sln project file and publish it to seperate folder
# Install nuget packages if any package is not already installed
# Deploy the files in IIS and give folder permissions
# Change the database connection string in the config
# Make database changes as below
 ## Create Database Inventory
 ## Create Table 
         USE [Inventory]
        GO

        /****** Object:  Table [dbo].[Products]    Script Date: 7/31/2020 12:18:36 PM ******/
        SET ANSI_NULLS ON
        GO

        SET QUOTED_IDENTIFIER ON
        GO

        CREATE TABLE [dbo].[Products](
          [ProductId] [int] IDENTITY(1,1) NOT NULL,
          [ProductName] [nvarchar](50) NOT NULL,
          [Price] [nvarchar](50) NULL,
          [Description] [nvarchar](max) NULL,
        PRIMARY KEY CLUSTERED 
        (
          [ProductId] ASC
        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
        ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
        GO


 ## Create stored procedure
       USE [Inventory]
      GO

      /****** Object:  StoredProcedure [dbo].[spAddProduct]    Script Date: 7/31/2020 12:18:15 PM ******/
      SET ANSI_NULLS ON
      GO

      SET QUOTED_IDENTIFIER ON
      GO

      Create procedure [dbo].[spAddProduct]
      @Name nvarchar(50),  
      @Description nvarchar(max),  
      @Price nvarchar(50) 
      as  
      Begin  
       Insert into products(ProductName, Description, Price)  
       Values (@Name, @Description, @Price)  
      End
      GO
# Run the application in the iis and create the products and view the products

