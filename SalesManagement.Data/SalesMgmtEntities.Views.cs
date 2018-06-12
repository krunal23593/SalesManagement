//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(SalesManagement.Data.SalesManagementDemoEntities),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets4eb3f2e872b582807f72b2985a858d84e63b51ae7d734cc766a735f0ba1ac404))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework 6 Power Tools", "0.9.2.0")]
    internal sealed class ViewsForBaseEntitySets4eb3f2e872b582807f72b2985a858d84e63b51ae7d734cc766a735f0ba1ac404 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "4eb3f2e872b582807f72b2985a858d84e63b51ae7d734cc766a735f0ba1ac404"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "SalesManagementDemoModelStoreContainer.Budget")
            {
                return GetView0();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Departments")
            {
                return GetView1();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Inventory")
            {
                return GetView2();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Orders")
            {
                return GetView3();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Products")
            {
                return GetView4();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Roles")
            {
                return GetView5();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Sales")
            {
                return GetView6();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.User_Details")
            {
                return GetView7();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Users")
            {
                return GetView8();
            }

            if (extentName == "SalesManagementDemoModelStoreContainer.Order_Details")
            {
                return GetView9();
            }

            if (extentName == "SalesManagementDemoEntities.Budgets")
            {
                return GetView10();
            }

            if (extentName == "SalesManagementDemoEntities.Departments")
            {
                return GetView11();
            }

            if (extentName == "SalesManagementDemoEntities.Inventories")
            {
                return GetView12();
            }

            if (extentName == "SalesManagementDemoEntities.Orders")
            {
                return GetView13();
            }

            if (extentName == "SalesManagementDemoEntities.Products")
            {
                return GetView14();
            }

            if (extentName == "SalesManagementDemoEntities.Roles")
            {
                return GetView15();
            }

            if (extentName == "SalesManagementDemoEntities.Sales")
            {
                return GetView16();
            }

            if (extentName == "SalesManagementDemoEntities.User_Details")
            {
                return GetView17();
            }

            if (extentName == "SalesManagementDemoEntities.Users")
            {
                return GetView18();
            }

            if (extentName == "SalesManagementDemoEntities.Order_Details")
            {
                return GetView19();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Budget.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Budget
        [SalesManagementDemoModel.Store.Budget](T1.Budget_Id, T1.Budget_DepartmentId, T1.Budget_Amounted, T1.Budget_Gains, T1.Budget_Loss, T1.Budget_MonthlyReportDate)
    FROM (
        SELECT 
            T.Id AS Budget_Id, 
            T.DepartmentId AS Budget_DepartmentId, 
            T.Amounted AS Budget_Amounted, 
            T.Gains AS Budget_Gains, 
            T.Loss AS Budget_Loss, 
            T.MonthlyReportDate AS Budget_MonthlyReportDate, 
            True AS _from0
        FROM SalesManagementDemoEntities.Budgets AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Departments.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Departments
        [SalesManagementDemoModel.Store.Departments](T1.Departments_Id, T1.Departments_Name)
    FROM (
        SELECT 
            T.Id AS Departments_Id, 
            T.Name AS Departments_Name, 
            True AS _from0
        FROM SalesManagementDemoEntities.Departments AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Inventory.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Inventory
        [SalesManagementDemoModel.Store.Inventory](T1.Inventory_Id, T1.Inventory_ProductId, T1.Inventory_InStock)
    FROM (
        SELECT 
            T.Id AS Inventory_Id, 
            T.ProductId AS Inventory_ProductId, 
            T.InStock AS Inventory_InStock, 
            True AS _from0
        FROM SalesManagementDemoEntities.Inventories AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Orders.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Orders
        [SalesManagementDemoModel.Store.Orders](T1.Orders_Id, T1.Orders_ProductId, T1.Orders_Quantity, T1.Orders_TransactionId, T1.Orders_TotalCost, T1.Orders_OrderDate)
    FROM (
        SELECT 
            T.Id AS Orders_Id, 
            T.ProductId AS Orders_ProductId, 
            T.Quantity AS Orders_Quantity, 
            T.TransactionId AS Orders_TransactionId, 
            T.TotalCost AS Orders_TotalCost, 
            T.OrderDate AS Orders_OrderDate, 
            True AS _from0
        FROM SalesManagementDemoEntities.Orders AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Products.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Products
        [SalesManagementDemoModel.Store.Products](T1.Products_Id, T1.Products_Name, T1.Products_Cost)
    FROM (
        SELECT 
            T.Id AS Products_Id, 
            T.Name AS Products_Name, 
            T.Cost AS Products_Cost, 
            True AS _from0
        FROM SalesManagementDemoEntities.Products AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Roles.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Roles
        [SalesManagementDemoModel.Store.Roles](T1.Roles_Id, T1.Roles_RoleName)
    FROM (
        SELECT 
            T.Id AS Roles_Id, 
            T.RoleName AS Roles_RoleName, 
            True AS _from0
        FROM SalesManagementDemoEntities.Roles AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Sales.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Sales
        [SalesManagementDemoModel.Store.Sales](T1.Sales_Id, T1.Sales_OrdersId, T1.Sales_InventoryId, T1.Sales_BudgetId, T1.Sales_UserId)
    FROM (
        SELECT 
            T.Id AS Sales_Id, 
            T.OrdersId AS Sales_OrdersId, 
            T.InventoryId AS Sales_InventoryId, 
            T.BudgetId AS Sales_BudgetId, 
            T.UserId AS Sales_UserId, 
            True AS _from0
        FROM SalesManagementDemoEntities.Sales AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.User_Details.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing User_Details
        [SalesManagementDemoModel.Store.User_Details](T1.[User_Details.Id], T1.[User_Details.UserId], T1.[User_Details.FirstName], T1.[User_Details.LastName], T1.[User_Details.Email])
    FROM (
        SELECT 
            T.Id AS [User_Details.Id], 
            T.UserId AS [User_Details.UserId], 
            T.FirstName AS [User_Details.FirstName], 
            T.LastName AS [User_Details.LastName], 
            T.Email AS [User_Details.Email], 
            True AS _from0
        FROM SalesManagementDemoEntities.User_Details AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Users.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Users
        [SalesManagementDemoModel.Store.Users](T1.Users_Id, T1.Users_UserName, T1.Users_PassWord, T1.Users_RoleId)
    FROM (
        SELECT 
            T.Id AS Users_Id, 
            T.UserName AS Users_UserName, 
            T.PassWord AS Users_PassWord, 
            T.RoleId AS Users_RoleId, 
            True AS _from0
        FROM SalesManagementDemoEntities.Users AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoModelStoreContainer.Order_Details.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Order_Details
        [SalesManagementDemoModel.Store.Order_Details](T1.[Order_Details.Id], T1.[Order_Details.CustomerFirstName], T1.[Order_Details.CustomerLastName], T1.[Order_Details.AccountType], T1.[Order_Details.DeliveryAddress])
    FROM (
        SELECT 
            T.Id AS [Order_Details.Id], 
            T.CustomerFirstName AS [Order_Details.CustomerFirstName], 
            T.CustomerLastName AS [Order_Details.CustomerLastName], 
            T.AccountType AS [Order_Details.AccountType], 
            T.DeliveryAddress AS [Order_Details.DeliveryAddress], 
            True AS _from0
        FROM SalesManagementDemoEntities.Order_Details AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Budgets.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Budgets
        [SalesManagementDemoModel.Budget](T1.Budget_Id, T1.Budget_DepartmentId, T1.Budget_Amounted, T1.Budget_Gains, T1.Budget_Loss, T1.Budget_MonthlyReportDate)
    FROM (
        SELECT 
            T.Id AS Budget_Id, 
            T.DepartmentId AS Budget_DepartmentId, 
            T.Amounted AS Budget_Amounted, 
            T.Gains AS Budget_Gains, 
            T.Loss AS Budget_Loss, 
            T.MonthlyReportDate AS Budget_MonthlyReportDate, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Budget AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Departments.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Departments
        [SalesManagementDemoModel.Department](T1.Department_Id, T1.Department_Name)
    FROM (
        SELECT 
            T.Id AS Department_Id, 
            T.Name AS Department_Name, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Departments AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Inventories.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView12()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Inventories
        [SalesManagementDemoModel.Inventory](T1.Inventory_Id, T1.Inventory_ProductId, T1.Inventory_InStock)
    FROM (
        SELECT 
            T.Id AS Inventory_Id, 
            T.ProductId AS Inventory_ProductId, 
            T.InStock AS Inventory_InStock, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Inventory AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Orders.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView13()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Orders
        [SalesManagementDemoModel.Order](T1.Order_Id, T1.Order_ProductId, T1.Order_Quantity, T1.Order_TransactionId, T1.Order_TotalCost, T1.Order_OrderDate)
    FROM (
        SELECT 
            T.Id AS Order_Id, 
            T.ProductId AS Order_ProductId, 
            T.Quantity AS Order_Quantity, 
            T.TransactionId AS Order_TransactionId, 
            T.TotalCost AS Order_TotalCost, 
            T.OrderDate AS Order_OrderDate, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Orders AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Products.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView14()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Products
        [SalesManagementDemoModel.Product](T1.Product_Id, T1.Product_Name, T1.Product_Cost)
    FROM (
        SELECT 
            T.Id AS Product_Id, 
            T.Name AS Product_Name, 
            T.Cost AS Product_Cost, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Products AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Roles.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView15()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Roles
        [SalesManagementDemoModel.Role](T1.Role_Id, T1.Role_RoleName)
    FROM (
        SELECT 
            T.Id AS Role_Id, 
            T.RoleName AS Role_RoleName, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Roles AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Sales.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView16()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Sales
        [SalesManagementDemoModel.Sale](T1.Sale_Id, T1.Sale_OrdersId, T1.Sale_InventoryId, T1.Sale_BudgetId, T1.Sale_UserId)
    FROM (
        SELECT 
            T.Id AS Sale_Id, 
            T.OrdersId AS Sale_OrdersId, 
            T.InventoryId AS Sale_InventoryId, 
            T.BudgetId AS Sale_BudgetId, 
            T.UserId AS Sale_UserId, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Sales AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.User_Details.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView17()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing User_Details
        [SalesManagementDemoModel.User_Details](T1.[User_Details.Id], T1.[User_Details.UserId], T1.[User_Details.FirstName], T1.[User_Details.LastName], T1.[User_Details.Email])
    FROM (
        SELECT 
            T.Id AS [User_Details.Id], 
            T.UserId AS [User_Details.UserId], 
            T.FirstName AS [User_Details.FirstName], 
            T.LastName AS [User_Details.LastName], 
            T.Email AS [User_Details.Email], 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.User_Details AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Users.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView18()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Users
        [SalesManagementDemoModel.User](T1.User_Id, T1.User_UserName, T1.User_PassWord, T1.User_RoleId)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.UserName AS User_UserName, 
            T.PassWord AS User_PassWord, 
            T.RoleId AS User_RoleId, 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Users AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for SalesManagementDemoEntities.Order_Details.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView19()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Order_Details
        [SalesManagementDemoModel.Order_Details](T1.[Order_Details.Id], T1.[Order_Details.CustomerFirstName], T1.[Order_Details.CustomerLastName], T1.[Order_Details.AccountType], T1.[Order_Details.DeliveryAddress])
    FROM (
        SELECT 
            T.Id AS [Order_Details.Id], 
            T.CustomerFirstName AS [Order_Details.CustomerFirstName], 
            T.CustomerLastName AS [Order_Details.CustomerLastName], 
            T.AccountType AS [Order_Details.AccountType], 
            T.DeliveryAddress AS [Order_Details.DeliveryAddress], 
            True AS _from0
        FROM SalesManagementDemoModelStoreContainer.Order_Details AS T
    ) AS T1");
        }
    }
}
