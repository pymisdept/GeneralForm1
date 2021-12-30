
            $(function()
            {
            		      
                var form2  = $("#form1").validate({
                   rules: {
                        txtPwd: {required: true, maxlength: 4, digits: true},
                        txtRef: {required: true}
                   },   
                   messages: {
                        txtPwd: {
                            required: "請填寫資料 Please input data",      
                            maxlength: "請填寫最後4位數字 Please input no more than 4 digits",      
                            digits: "請填寫最後4位數字 Please input last 4 digits"                            
                        },
                        txtRef: {
                            required: "請填寫資料 Please input data"
                        }
                    }
                });
                
            });