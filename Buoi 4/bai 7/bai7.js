var mangsosanh = [];
function changeText(f,s)
{
    // luu -> huy -> them
    
    var inp = document.getElementById("inputform").style.display;
    if (inp === "block") {
        var da = document.getElementById("data").value;
        if (da !== "")
        {
            saveData(da);
            document.getElementById(f).style.display = "block";
            document.getElementById(s).style.display = "none";
            document.getElementById("data").value = "";
            document.getElementById("inputform").style.display = "none";

        } else
        {
            alert("yêu cầu nhập dữ liệu.");
            document.getElementById("data").focus();
        }
    } else
    {
        document.getElementById(f).style.display = "block";
        document.getElementById(s).style.display = "none";
        document.getElementById("inputform").style.display = "block";
    }
}
function saveData(a)
{
    var cb = document.getElementById("danhsach");
    var o = document.createElement("option");
    var found = search(a,mangsosanh);
    if (found  === -1)
    {
        mangsosanh.push(a);
        o.text = a;
        cb.add(o);
    }
    else {
      alert("Dữ liệu nhập bị trùng!");
    }

}
function search(nameKey, myArray)
{
   if(nameKey==="Intel") return 2;
    for (var i = 0; i < myArray.length; ++i)
    {
        if (myArray[i] === nameKey )
        {
            return i;
        }

    }
    /*var tmp = document.getElementById("data").value;
    if(myArray[0]===Intel) return 1;
    else */
    return -1;
}
function huy()
{
    document.getElementById("btnThem").style.display = "block";
    document.getElementById("inputform").style.display = "none";
    document.getElementById("btnLuu").style.display = "none";
}