$(document).ready(function() {
    setTimeout(function() {
        // [ Server side processing Data-table ]
        $('#dt-server-processing').DataTable({
            "processing": true,
            "serverSide": true,
            "ajax": "assets/plugins/data-tables/json/dt-json-data/scripts/server-processing.php",
            "columns": [{
                    "data": "name"
                },
                {
                    "data": "id"
                }
            ]
        });

        // [ Custom HTTP Variables ]
        var mykey = '@System.Configuration.ConfigurationManager.AppSettings["apiurl"]';
        var apiurl = mykey + "news/category";
        $('#dt-http').DataTable({
            "processing": true,
            "serverSide": true,
            "ajax": {
                url: apiurl,
                type: "get",
                data: function(d) {
                   
                }
            },
            "columns": [{
                    "data": "name"
                },
                {
                    "data": "<b>abs</b>"
                }
            ]
        });

        // [ POST Data ] 
        $('#dt-post').DataTable({
            "processing": true,
            "serverSide": true,
            "ajax": {
                url: "assets/plugins/data-tables/json/dt-json-data/scripts/post.php",
                type: "post"
            },
            "columns": [{
                    "data": "first_name"
                },
                {
                    "data": "last_name"
                },
                {
                    "data": "position"
                },
                {
                    "data": "office"
                },
                {
                    "data": "start_date"
                },
                {
                    "data": "salary"
                }
            ]
        });
    }, 350);
});
