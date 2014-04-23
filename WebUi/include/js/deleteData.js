$(function () {
    setSize();
});

//调整顶部菜单大小
function setSize() {
    var w = document.getElementById("tb").clientWidth;
    document.getElementById("topmod").style.width = (parseInt(w) - parseInt(11)) + "px";
    document.getElementById("searchMod").style.width = (parseInt(w) - parseInt(11)) + "px";
}

//单一的删除方式
function deleteByID(id) {
    var t = confirm("确定要删除该条？");
    if (t == true) {
        window.open((location.href + '?action=delete&id=' + id), "_self");
    } else {

    }
}


/*  jquery方式选择所有单选框
    @ id  复选框上层元素的id
*/
function checkAllBox(id) {
    var cbs = $("#"+id+" :checkbox");
    for (var i = 1; i < cbs.length; i++) {
        $(cbs[i]).prop("checked", !$(cbs[i]).prop("checked"));
    }
}

/*  jquery方式删除所有选中项
    @ id  复选框上层元素的id
*/
function deleteIDs(id) {
    var cbs = $("#"+id+" :checkbox");
    var ids = '';
    for (var i = 1; i < cbs.length; i++) {
        if ($(cbs[i]).prop("checked") == true) {
            if (ids == '') {
                ids += $(cbs[i]).val();
            } else {
                ids += ',' + $(cbs[i]).val();
            }
        }
    }
    if (ids != "") {
        var t = confirm("确定要删除该条？");
        if (t == true) {
            var data = '?action=deleteIDs&ids=' + ids;
            window.open(location.href + data, "_self");
        } else {

        }
    } else {
        alert("请选择要删除的项！");
    }
}