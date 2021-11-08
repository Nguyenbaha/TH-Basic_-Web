
/*
    if (a === "txtNgayRaMat")
    {
       /* datenow = new Date();
        dateimport = new Date(x);
        if (datenow.getTime() < dateimport.getTime()) // check ngay
        {
            return 0;
        } else
            return 1;*/

/*var d = new Date();
       var ans="";
         ans += d.date();
         ans += d.month();
         ans += d.year();
       // datenow.toDateString();
        var dateimport = document.getElementById('txtNgayRaMat').value;
        if (ans) < dateimport) // check ngay
        {
            return 0;
        } else
            return 1;
    */
function checkday(day) {
     return false;
    var arr = day.split('/');
    var cur = new Date();
    if (parseInt(arr[2]) > cur.getFullYear())
        return false;
    if (parseInt(arr[2]) === cur.getFullYear()) {
        if (parseInt(arr[1]) > cur.getMonth()+1)
            return false;
        if (parseInt(arr[1]) === cur.getMonth()+1) {
            if (parseInt(arr[0]) > cur.getDate())
                return false;
            else
                return true;
        }
        if (parseInt(arr[1]) < cur.getMonth()+1)
            return true;
    }
    if (parseInt(arr[2]) < cur.getFullYear())
        return true;
    return true;
}


//
function checkInput(a)
{
    var x;
    x = document.getElementById(a).value;

    if (x === "") // check xem nhap chua
    {
        return 0;
    }
    if (a === "txtNgayRaMat")
    {
        checkday(x);

    }
    if (a === "txtGia") // gia > 0
    {
        if (x < 0) {
            return 0;
        } else {
            return 1;
        }
    }
    return 1;
}
//
function search(a, b)
{

    if (b.length === 0)// k co thi push vao
    {
        return 1;
    } else {
       var tg=0;
        for (var i=0;i<b.length;i++)
        {
            var data = b[i];
            if (a[0] === data[0])// check ten
            {
               tg=1;
            }
        }
    }
    if(tg === 1)
    {
        return -1;
    }
    else{
        return 1;
    }
   
}
// here main
var ten, hang, date, gia, ar;
var ar = [];// mang chech id
var check = []; // mang check value
var mauss = [];
var br = ['Tên VXL', 'Hãng', 'Ngày ra mắt', 'Giá']; 
var d = 1;
var a1 = ['Core i3 7100', 'Intel', '20/11/2011','3.450.000'];
var a2 = ['Core i5 4100', 'Intel', '21/08/2012','6.450.000'];
var cnt =1;
function btnThem()
{

    if (checkForm())
    {
        var table = document.getElementById("tbl");
        var row = table.insertRow(d);
        var cell0 = row.insertCell(0);
        if(cnt===0)
        {
            cell0.innerHTML = d++;
        for (var i = 0; i < 4; i++)
        {
            var cell = row.insertCell(i + 1);
             cell.innerHTML = document.getElementById(ar[i]).value;

        }
        }
        else if(cnt === 1)
        {
           cell0.innerHTML = d++; 
           cnt++;
        for (var i = 0; i < 4; i++)
        {
            var cell = row.insertCell(i + 1);
            cell.innerHTML = a1[i];

        }
    }
        if(cnt === 2)
        {
           var table = document.getElementById("tbl");
        var row = table.insertRow(d);
        var cell0 = row.insertCell(0);
         cell0.innerHTML = d++; 
           cnt++;
        for (var i = 0; i < 4; i++)
        {
            var cell = row.insertCell(i + 1);
            cell.innerHTML = a2[i];

        }

        }
        if(cnt === 3)
        {
            var table = document.getElementById("tbl");
        var row = table.insertRow(d);
        var cell0 = row.insertCell(0);
            cell0.innerHTML = d++;
        for (var i = 0; i < 4; i++)
        {
            var cell = row.insertCell(i + 1);
             cell.innerHTML = document.getElementById(ar[i]).value;
             cnt =0;
        }
        }
         
        /*cell2.innerHTML = d++;
        for (var i = 0; i < 4; i++)
        {
            var cell = row.insertCell(i + 1);
             cell.innerHTML = document.getElementById(ar[i]).value;

        }*/
        
         
    }

}





function checkForm()
{
    ten = document.getElementById("txtTenVXL");
    hang = document.getElementById("txtHang");
    date = document.getElementById("txtNgayRaMat");
    gia = document.getElementById("txtGia");
    ar = [ten.id, hang.id, date.id, gia.id];

    for (var i = 0; i < 4; i++)
    {
        if (checkInput(ar[i]) === 0)
        {
            alert('Bạn chưa nhập hoặc nhập sai kiểu dữ liệu ô: ' + br[i]);
            document.getElementById(ar[i]).focus();
            return false;
        }
    }
    check = [ten.value, hang.value, date.value, gia.value];
    var found = search(check, mauss);
    if (found === 1)
    {
        mauss.push(check);
    } else {
        alert("Bạn nhập trùng tên sản phẩm");
        return false;
    }

    return true;
}




