window.addEventListener("resize", ChangeHeaderStatus);
function ChangeHeaderStatus() {
    var width = window.innerWidth;
    if (width < 900) {
        document.getElementById("listMenu").classList.remove("list-menu");
        document.getElementById("Register").classList.add("list-menu");
        document.getElementById("Login").classList.add("list-menu");
        document.getElementById("lg-logo").classList.add("list-menu");
        document.getElementById("sm-logo").classList.remove("list-menu");

        document.getElementById("HeadFeature").classList.remove("col-md-6");
        document.getElementById("HeadFeature").classList.add("col-md-5");
        document.getElementById("KhuyenMai").classList.remove("col-md-3");
        document.getElementById("KhuyenMai").classList.add("col-md-6");
        document.getElementById("Cart").classList.remove("col-md-3");
        document.getElementById("Cart").classList.add("col-md-6");
    }
    else {
        document.getElementById("listMenu").classList.add("list-menu");
        document.getElementById("Register").classList.remove("list-menu");
        document.getElementById("Login").classList.remove("list-menu");
        document.getElementById("lg-logo").classList.remove("list-menu");
        document.getElementById("sm-logo").classList.add("list-menu");

        document.getElementById("HeadFeature").classList.remove("col-md-5");
        document.getElementById("HeadFeature").classList.add("col-md-6");
        document.getElementById("KhuyenMai").classList.remove("col-md-6");
        document.getElementById("KhuyenMai").classList.add("col-md-3");
        document.getElementById("Cart").classList.remove("col-md-6");
        document.getElementById("Cart").classList.add("col-md-3");
    }
}