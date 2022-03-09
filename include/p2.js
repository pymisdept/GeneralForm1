
            $(function()
            {
            		      
                var form2  = $("#form1").validate({
                   rules: {
                        txtPwd: {required: true, maxlength: 4},
                        txtRef: {required: true}
                   },   
                   messages: {
                        txtPwd: {
                            required: "請填寫資料 Please input data",      
                            maxlength: "請填寫身份證明文件號首4位字元 Please enter the first 4 characters of your Identitfication document number"                            
                        },
                        txtRef: {
                            required: "請填寫資料 Please input data"
                        }
                    }
                });
                
            });