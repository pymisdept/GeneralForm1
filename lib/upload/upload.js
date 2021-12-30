$(function () {

    $('#btnFileUpload').fileupload({
        url: 'FileUploadHandler.ashx?upload=start',
        add: function (e, data) {
            
            var isValid = true;
            var errMsg = "";
            var extension = data.originalFiles[0].name.replace(/^.*\./, '');
            var size = data.originalFiles[0].size ;
            extension = extension.toLowerCase();
            
           if(extension != "jpg" && extension != "jpeg" && extension != "png" && extension != "pdf" && extension != "doc" && extension != "docx")
           {
                errMsg = "檔案的格式不正確 Invalid File Format";
                isValid = false;
           }
           
           if(size > 10485760)
           {
             if(errMsg != "")
                errMsg += "\n" + "每個上載檔案不得超過10MB Each file size must not exceed 10MB";
             else
                errMsg = "每個上載檔案不得超過10MB Each file size must not exceed 10MB";
             
             isValid = false;
           }
           
           var fffval = $('#upFileH').val();       
           var lgt = fffval.split("*").length;
           if(lgt >= 5)
           { 
             if(errMsg != "")
                errMsg += "\n" + "最多只可以上載5個檔案 The maximum number of files that can be uploaded is 5";
             else
                errMsg = "最多只可以上載5個檔案 The maximum number of files that can be uploaded is 5";
                
                isValid = false;
           } 
           
           if(!isValid)
           {
                alert(errMsg);
                return false;
           }
           else
           {
                $('#progressbar').show();
                data.submit();
           }
        },
        success: function (response, status) {
            $('#progressbar').hide();
            
            str = JSON.parse(response);            
            var str2 = str["fi"] + "|" + str["fn"] + "|" + str["fl"] ;

            $('#mygroup').append( "<div id='"+ str["fi"].split(".")[0] +"' class='col-12 row subrow'><div class='col-6'>" + str["fn"] + "</div><div class='col-3'>" + str["fl"] + "</div><div class='rmFRow col-3'>" + "<a href='#'>Delete</a>" + "</div></div>" );
            
            var fffval = $('#upFileH').val();                     
            
            if(fffval == "")
            {
              fffval = str2;
              $('#upFileH').attr('value',fffval);
            }
            else
            {
              fffval = fffval + "*" + str2;
              $('#upFileH').attr('value',fffval);
            }
            
           
        },
        error: function (error) {
            $('#progressbar').hide();
        }
    });
    
    
    $('body').on('click', '.rmFRow', function(e)
    {
        var obj = $(this).parents('.subrow');
        
        var n_fffval = "";
        var rsA =  $('#upFileH').val().split("*");
        
        var id = obj.attr('id');
        
        for(k=0; k<rsA.length; k++)
        {
            if(rsA[k].indexOf(id) >= 0)
                continue;
            else
            {
                if(n_fffval == "")
                    n_fffval = rsA[k];
                else
                    n_fffval = n_fffval + "*" + rsA[k];
            }
        }
        
       $('#upFileH').attr('value',n_fffval);
        
        obj.fadeOut(100, function() {
            $(this).remove();
        });
        
    });
        
});
