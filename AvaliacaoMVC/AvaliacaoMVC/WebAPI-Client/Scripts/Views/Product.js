//sem jquery
function getAllProducts() {
    $.ajax({
        url: '/Home/GetAllData',
        dataType: 'json',
        method: 'GET',
        success: function (result) {
            if (result.length > 0) {
                var table = document.getElementById('tableHtml');
                table.style.display = 'table';

                var content = document.getElementById('contentHtml');
                content.innerHTML = "";

                for (var i = 0; i < result.length; i++) {
                    var tr = document.createElement("tr");
                    tr.innerHTML = "<td>" + result[i].Description + "</td><td>" + result[i].Company + "</td><td>" + result[i].CompanyCode + "</td><td align='right'> R$ " + result[i].Value + "</td>";
                    content.appendChild(tr);
                }
            }
        },
        error: function (xhr, textStatus, exceptionThrown) {
            var errorData = $.parseJSON(xhr.responseText);
            alert(errorData);
        }
    });
}

//com jquery
function getAllProductsJ() {
    $.ajax({
        url: '/Home/GetAllData',
        dataType: 'json',
        method: 'GET',
        success: function (result) {
            if (result.length > 0) {
                var tableJ = $('#tableHtmlJ');
                tableJ.css('display', 'table');

                var content = document.getElementById('contentHtmlJ');
                content.innerHTML = "";

                for (var j = 0; j < result.length; j++) {
                    tableJ.append("<tr><td>" + result[j].Description + "</td><td>" + result[j].Company + "</td><td>" + result[j].CompanyCode + "</td><td align='right'> R$ " + result[j].Value + "</td></tr>");
                }
            }
        },
        error: function (xhr, textStatus, exceptionThrown) {
            var errorData = $.parseJSON(xhr.responseText);
            alert(errorData);
        }
    });
}

//Eventos
$('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
    var target = $(e.target).attr("id"); // activated tab
    if (target === 'tabwithout') {
        var table = document.getElementById('tableHtml');
        table.style.display = 'none';
        var content = document.getElementById('contentHtml');
        content.innerHTML = "";
    }
    else if (target === 'tabwith') {
        var tableJ = $('#tableHtmlJ');
        tableJ.css('display', 'none');
        var contentJ = document.getElementById('contentHtmlJ');
        contentJ.innerHTML = "";
    }
});