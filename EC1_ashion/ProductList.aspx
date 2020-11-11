<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="EC1_ashion.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Product List Section Begin -->
    <section class="ProdList spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-3">
                    <div class="ProdList__sidebar">
                        <div class="sidebar__categories">
                            <div class="section-title">
                                <h4><a href="ProductList.aspx" style="color: black">All Categories</a></h4>
                            </div>
                            <div class="categories__accordion">
                                <div class="accordion" id="accordionExample">
                                    <asp:ListView ID="categoryList"
                                        ItemType="EC1_ashion.Models.Category"
                                        runat="server" SelectMethod="GetCategories">
                                        <ItemTemplate>
                                            <div class="card">
                                                <div class="card-heading">
                                                    <a href="ProductList.aspx?id=<%#: Item.CategoryID %>">
                                                        <%#: Item.CategoryName %>
                                                    </a>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </div>
                            </div>
                        </div>

                        <!--
                        <div class="sidebar__filter">
                            <div class="section-title">
                                <h4>Shop by price</h4>
                            </div>
                            <div class="filter-range-wrap">
                                <div class="price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content"
                                    data-min="0" data-max="900">
                                </div>
                                <div class="range-slider">
                                    <div class="price-input">
                                        <p>Price:</p>
                                        <asp:textbox type="text" id="minamount" runat="server"></asp:textbox>
                                        <asp:textbox type="text" id="maxamount" runat="server"></asp:textbox>
                                    </div>
                                </div>
                            </div>
                            <asp:Button ID="Filter" runat="server" Text="Filter"></asp:Button>
                            <a href="#">Filter</a>
                        </div>-->

                    </div>
                </div>
                <div class="col-lg-9 col-md-9">
                    <div class="row">
                        <asp:ListView ID="productList" runat="server" DataKeyNames="ProductID"
                            ItemType="EC1_ashion.Models.Product" SelectMethod="GetProducts" OnPagePropertiesChanging="productList_PagePropertiesChanging">
                            <EmptyDataTemplate>
                                <table>
                                    <tr>
                                        <td>No data was returned.</td>
                                    </tr>
                                </table>
                            </EmptyDataTemplate>
                            <EmptyItemTemplate>
                                <td />
                            </EmptyItemTemplate>
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6">
                                    <div class="product__item">
                                        <div class="product__item__pic set-bg" data-setbg="img/product/<%#:Item.ImagePath1%>">
                                            <!--
                                            <div class="label new">New</div>
                                            <div class="label stockout stockblue">Out Of Stock</div>
                                            <div class="label">Sale</div>
                                            -->
                                            <ul class="product__hover">
                                                <li><a href="img/product/<%#:Item.ImagePath1%>" class="image-popup"><span class="fa fa-expand"></span></a></li>
                                                <li><a href="#"><span class="fa fa-heart-o"></span></a></li>
                                                <li><a href="ProductDetails.aspx?productID=<%#:Item.ProductID %>"><span class="fa fa-shopping-bag"></span></a></li>
                                            </ul>
                                        </div>

                                        <div class="product__item__text">
                                            <h6><a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>"><%#:Item.ProductName%></a></h6>
                                            <div class="rating">
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                            </div>
                                            <!-- add to discount -->
                                            <asp:Label ID="Price" runat="server" class="product__price">$ <%#:Item.UnitPrice%></asp:Label>
                                            <asp:Label ID="Discount" runat="server" class="hidden"> <%#:Item.Discount%> </asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                    <div class="col-lg-12 text-center">
                        <div class="pagination__option">
                            <asp:DataPager ID="DPGProduct" runat="server" PagedControlID="productList" PageSize="8">
                                <Fields>
                                    <asp:NextPreviousPagerField ShowNextPageButton="False" NextPageText=">" PreviousPageText="<" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ShowPreviousPageButton="False" NextPageText=">" PreviousPageText="<" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Product List Section End -->
</asp:Content>
