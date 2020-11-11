<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EC1_ashion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Preloder -->
    <div id="preloder">
        <div class="loader"></div>
    </div>
    <!-- Categories Section End -->
    <section class="categories">
        <div class="container-fluid">
            <div class="row">
                <asp:Repeater ID="rptr1st" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-6 p-0">
                            <div class="categories__item categories__large__item set-bg"
                                data-setbg="img/categories/<%# Eval("CategoryImagePath") %>">
                                <div class="categories__text">
                                    <h1><%# Eval("CategoryName") %></h1>
                                    <p><%# Eval("Description") %></p>
                                    <a href="ProductList.aspx?id=<%# Eval("CategoryID") %>">Shop now</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

                <div class="col-lg-6">
                    <div class="row">
                        <asp:Repeater ID="rptrAll" runat="server">
                            <ItemTemplate>
                                <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                                    <div class="categories__item set-bg" data-setbg="img/categories/<%# Eval("CategoryImagePath") %>">
                                        <div class="categories__text">
                                            <h4><%# Eval("CategoryName") %></h4>
                                            <p><%# Eval("AmountOfItems") %> item(s)</p>
                                            <a href="ProductList.aspx?id=<%# Eval("CategoryID") %>">Shop now</a>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Categories Section End -->

    <!-- Product Section Begin -->
    <section class="product spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 col-md-4">
                    <div class="section-title">
                        <h4>Featured</h4>
                    </div>
                </div>

                <div class="col-lg-8 col-md-8">
                    <ul class="filter__controls">
                        <li class="active" data-filter="*">All</li>
                        <li data-filter=".cat1">Women’s</li>
                        <li data-filter=".cat2">Men’s</li>
                        <li data-filter=".cat3">Kid’s</li>
                        <li data-filter=".cat4">Accessories</li>
                        <li data-filter=".cat5">Cosmetics</li>
                    </ul>
                </div>
            </div>

            <div class="row property__gallery">
                <asp:Repeater ID="Featured" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-3 col-md-4 col-sm-6 mix cat<%# Eval("CategoryID") %>">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/product/<%# Eval("ImagePath1") %>">
                                    <!--
                                        <div class="label new">New</div>
                                        <div class="label stockout">out of stock</div>
                                        <div class="label">Sale</div>
                                        <div class="product__price">$ 49.0 <span>$ 59.0</span></div> discount
                                        -->
                                    <ul class="product__hover">
                                        <li><a href="#"><span class="fa fa-heart-o"></span></a></li>
                                        <li><a href="ProductDetails.aspx?productID=<%# Eval("ProductID") %>"><span class="fa fa-shopping-bag"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="ProductDetails.aspx?productID=<%# Eval("ProductID") %>"><%# Eval("ProductName") %></a></h6>
                                    <div class="rating">
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                    </div>
                                    <asp:Label ID="price" class="product__price" runat="server"><%# Eval("UnitPrice") %></asp:Label>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>
    <!-- Product Section End -->

    <!-- Banner Section Begin -->
    <section class="banner set-bg" data-setbg="img/banner/banner-2.jpg">
        <div class="container">
            <div class="row">
                <div class="col-xl-7 col-lg-8 m-auto">
                    <div class="banner__slider owl-carousel">
                        <asp:Repeater ID="slideAccess" runat="server">
                            <ItemTemplate>
                                <div class="banner__item">
                                    <div class="banner__text">
                                        <span><%# Eval("Brand") %> Collection</span>
                                        <h1><%# Eval("ProductName") %></h1>
                                        <a href="ProductDetails.aspx?productID=<%# Eval("CategoryID") %>">Shop now</a>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Banner Section End -->

    <!-- Services Section Begin -->
    <section class="services spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-car"></i>
                        <h6>Free Shipping</h6>
                        <p>For all order</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-money"></i>
                        <h6>Money Back Guarantee</h6>
                        <p>If you have a problem</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-support"></i>
                        <h6>Online Support 24/7</h6>
                        <p>Dedicated support</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-headphones"></i>
                        <h6>Payment Secure</h6>
                        <p>100% secure payment</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Services Section End -->
</asp:Content>
