# warehouse-management-tool
Create a tool Warehouse Management with WPF MVVM (for learning)


The solution is from [HowKteam.com](https://www.howkteam.vn/course/lap-trinh-phan-mem-quan-ly-kho-wpf-mvvm-42)

- Using Principe : Model - View - View Model (MVVM)
- Using Material Design
- Using User Controler

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




## UI

<p align="center">
  <img src="https://i.imgur.com/gtW4k9n.png" alt="Login" />
  <img src="https://i.imgur.com/T712Cjs.png" alt="Program" />
</p>
