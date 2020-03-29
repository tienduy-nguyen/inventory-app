# warehouse-management-tool
An exemple shows how to create a tool Warehouse Management with WPF and SQL Server (for learning)


Reference: [HowKteam.com](https://www.howkteam.vn/course/lap-trinh-phan-mem-quan-ly-kho-wpf-mvvm-42)
- DB with SQL Server
- Using MVVM pattern
- Using Material Design
- Using UserControler and add it into MainWindow
- Add, Delete, Edit Database with WPF

## CURD

|Object       |Unit         |Suplier     |Customer       |Input        |Input Info    | Output        | Output Info   |                                                                                                                 
| ------------|-------------| -----------|---------------|-------------|--------------|---------------|---------------|
| Id          |Id           |Id          |Id             |Id           |Id            |Id             |Id             |
| DisplayName |DisplayName  |DisplayName |DisplayName    |DateInput    |IdObject      |DateInput      |IdObject       |
| IdUnit      |             |Address     |Address        |             |IdInput       |               |IdInput        |
| IdSuplier   |             |Phone       |Phone          |             |Count         |               |Count          |
| QRCode      |             |Email       |Email          |             |InputPrice    |               |IdCustomer     |
| BarCode     |             |MoreInfo    |MoreInfo       |             |OutputPrice   |               |DateOutput     |
|             |             |ContractDate|ContractDate   |             |Status        |               |Status         |




## GUI

<p align="center">
  <img src="https://i.imgur.com/gtW4k9n.png" alt="Login" />
  
  
  <img src="https://i.imgur.com/T712Cjs.png" alt="Program" />
  
  
  <img src="https://i.imgur.com/JHSdeIr.png" alt="GoodsReceipt" />
  <img src="https://i.imgur.com/miqh579.png" alt="GoodsIssue" />
  <img src="https://i.imgur.com/yAW57pq.png" alt="Materials" />
  <img src="https://i.imgur.com/cXxLhwV.png" alt="Unit" />
  <img src="https://i.imgur.com/sh6jTtq.png" alt="Supplier" />
  <img src="https://i.imgur.com/VzQ5GVE.png" alt="Customers" />
  <img src="https://i.imgur.com/OcPJWgB.png" alt="User" />
</p>

