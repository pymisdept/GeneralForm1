
            $(function()
            {
                
		    var validator = $("#myform").validate({
			rules: {  
                        fUpload1:{
                                required: true,
                                extension:"pdf|doc|docx",
                                filesize: 10485760
                            },
                        fUpload2:{
                                extension:"pdf|doc|docx",
                                filesize: 10485760
                        }  ,
                        fUpload3:{
                                extension:"pdf|doc|docx",
                                filesize: 10485760
                        }  ,
                        fUpload4:{
                                extension:"pdf|doc|docx",
                                filesize: 10485760
                        }  ,
                        fUpload5:{
                                extension:"pdf|doc|docx",
                                filesize: 10485760
                        }  ,
                        PosApplied : {
                               required: true,
                        },
                        ptitle:{
                                required: true
                        }  ,
                        EngSurName:{
                                required: true
                        }  ,
                        EngOtherName:{
                                required: true
                        }  ,
                        email:{
                                required: true,
                                email: true
                        }  ,
                        phone:{
                                required: true,
                        }  ,
                        checkDeclaration:{
                            custRequired: true
                        },
                        addr_ds:{
                            required: true
                        }
                    },
                messages: {
                        ptitle: {
                            required: "請選擇稱謂 Please select Salutation"
                        },
                        PosApplied: {
                            required: "請選擇申請職位 Please select the Position"
                        },
                        EngSurName: {
                            required: "請填寫英文姓氏 Please enter English Surname"
                        },
                        EngOtherName: {
                            required: "請填寫英文名字 Please enter English Other Name"
                        },
                        email: {
                            required: "請填寫電郵地址 Please enter Email address",
                            email: "請填寫正確的電郵地址 Please enter a valid Email Address"
                        },
                        phone: {
                            required: "請填寫電話 Please enter Phone No."
                        },
                        fUpload1:{
                                required: "請上載PDF / Word 檔案 Please upload PDF / Word File",
                                extension: "請上載PDF / Word 檔案 Please upload PDF / Word File",
                                filesize: "每個上載檔案不得超過10MB Each file size must not exceed 10MB"
                            } ,
                        fUpload2:{                                
                                extension: "請上載PDF / Word 檔案 Please upload PDF / Word File",
                                filesize: "每個上載檔案不得超過10MB Each file size must not exceed 10MB"
                            } ,
                        fUpload3:{                                
                                extension: "請上載PDF / Word 檔案 Please upload PDF / Word File",
                                filesize: "每個上載檔案不得超過10MB Each file size must not exceed 10MB"
                            } ,
                        fUpload4:{                                
                                extension: "請上載PDF / Word 檔案 Please upload PDF / Word File",
                                filesize: "每個上載檔案不得超過10MB Each file size must not exceed 10MB"
                            } ,
                        fUpload5:{                                
                                extension: "請上載PDF / Word 檔案 Please upload PDF / Word File",
                                filesize: "每個上載檔案不得超過10MB Each file size must not exceed 10MB"
                            } ,
                        checkDeclaration:{
                                custRequired: "* 請細閱以下內容 Please read this carefully"
                            }  ,
                            
                        addr_st:{
                            required: "請填寫街道 Please enter Street"
                        },
                            
                        addr_ds:{
                            required: "請選擇地區 Please select District"
                        },
                        addr_bd:{
                            required: "請填寫大廈/屋苑 Please enter Building/Estate"
                        }
                        
                    }      
		        });		        		        $.validator.addMethod("custRequired", $.validator.methods.required,"*");		        $.validator.addMethod("custDigits", $.validator.methods.digits,"*");		        $.validator.addMethod("custMinLgt", $.validator.methods.minlength,"*");		        $.validator.addMethod("custMaxLgt", $.validator.methods.maxlength,"*");		        $.validator.addMethod("custRange", $.validator.methods.range,"*");		        $.validator.addMethod("custNum", $.validator.methods.number,"*");		        		        		         $.validator.addMethod("custLessThan",		           function(value, element, param) {
                        if (this.optional(element)) return true;
                        
                        var mid = element.name;
                        var m1;
                        
                        if(mid == "ctrl_txt_GRC")		                   m1 = $("#ctrl_txt_GRP"); 
		                else
		                {
		                    stArr = mid.split('_');		                    
                            m1 = $("#ctrlDynamic_txt_GRP_6_" + stArr[4] );                            		                
		                }
		                
                        var i = parseFloat(value);
                        var j = parseFloat($(m1).val());
                        
                        return j <= i ;
                }, "*");                                		        /*		        $.validator.addMethod("custMValidation",		        		             function(value, element){     		                   var mid = element.name;		                   var m1;		                   		                   var cType;		                   		                   var PVal;		                   var CVal;		                   		                   var isNull;		                   		                   var c1;		                   var c2;		                   var e1;		                   var e2;		                   		                   if(mid == "ctrl_txt_GRD")		                   {		                         curIsGRA = true;		                         m1 = $("#ctrl_dlist_RES"); 		                         isNull = value == "";		                         		                         cType = 'D';		                   }		                   else if (mid == "ctrl_txt_GRP" || mid == "ctrl_txt_GRC")		                   {		                         curIsGRA = false;		                         m1 = $("#ctrl_dlist_RES"); 		                         isNull = value == "";		                         		                         if(mid == "ctrl_txt_GRP")		                         {		                            PVal = value;		                            CVal = $("#ctrl_txt_GRC").val();		                            		                            cType = 'P';		                         }		                         else		                         {		                            PVal = $("#ctrl_txt_GRP").val();		                            CVal = value;		                            		                            cType = 'C';		                         }		                         		                         c1 = $("#ctrl_txt_GRP");		                         c2 = $("#ctrl_txt_GRC");		                         		                         e1 = $("#ctrl_txt_GRP-error");		                         e2 = $("#ctrl_txt_GRC-error");		                   }		                   else		                   {
		                        stArr = mid.split('_');
		                        curIsGRA = mid.startsWith("#ctrlDynamic_txt_GRD");		                        
                                m1 = $("#ctrlDynamic_dlist_RES_6_" + stArr[4] );                                                                 isNull = value == "";                                                                if(curIsGRA)                                {                                    cType = 'D';                                                               }                                else                                {                                    if(mid.startsWith("#ctrlDynamic_txt_GRP"))                                        cType = 'P';   		                            else                                        cType = 'C';   		                            		                         		                            c1 = $("#ctrlDynamic_txt_GRP_6_" + stArr[4]);   		                            c2 = $("#ctrlDynamic_txt_GRC_6_" + stArr[4]);    		                            e1 = $("#ctrlDynamic_txt_GRP_6_" + stArr[4] + "-error");   		                            e2 = $("#ctrlDynamic_txt_GRC_6_" + stArr[4] + "-error");                                    }		                   }		                   		                   if(m1.val() == "GRA")		                    isGRA = true;		                   else		                    isGRA = false;		                    		                    		                   if(isGRA)		                   {		                       if(cType == 'D' && isNull)		                         return false;		                   }		                   else		                   {		                       // (1)		                       if(isNull)		                            return false;		                     		                       if(cType == 'P')		                       {		                           if(!$.isNumeric(c1.val()))                                     return false;                                                                      if(c2.val() != "" )                                   {                                     if($.isNumeric(c2.val()))                                     {                                                                            if(c2.val() > 0 && c2.val() <= 1000)                                       {                                 	        c1.removeClass("error");	                                        c2.removeClass("error");        		                       	                                        e1.hide();	                                        e2.hide();	                                   }                                                                                                                     if(c1.val() > c2.val())                                            return false;                                     }                                   }		                       }		                       else		                       {		                           if(!$.isNumeric(c2.val()))                                     return false;                                                                          if(c1.val() != "" )                                   {                                     if($.isNumeric(c1.val()))                                     {                                       if(c1.val() > 0 && c1.val() <= 1000)                                       {                                 	        c1.removeClass("error");	                                        c2.removeClass("error");        		                       	                                        e1.hide();	                                        e2.hide();	                                   }                                                                               if(c1.val() > c2.val())                                            return false;                                     }                                   }		                       }		                   }		                   		                   return true;	                        	             		             } ,"*"		        );		        */                
                $.validator.addMethod( 
                    'email',
                    function(value, element){                        
                        return this.optional( element ) || /[a-z]+@[a-z]+\.[a-z]+/.test( value );
                    }
                );
                                		        $.validator.addMethod('filesize', function(value, element, param) {
                    // param = size (in bytes) 
                    // element = element to validate (<input>)
                    // value = value of the element (file name)
                    return this.optional(element) || (element.files[0].size <= param) 
                });		        jQuery.validator.addClassRules({
                  formdl: {
                    custRequired: true
                  },
                  formtx: {
                    custRequired: true
                  },
                  formtxm: {
                    custRequired: true,
                    custDigits: true,
                    custMinLgt: 2,
                    custMaxLgt: 2,
                    custRange: [1, 12]
                  },
                  formtxy: {
                    custRequired: true,
                    custDigits: true,
                    custMinLgt: 4,
                    custMaxLgt: 4,
                    custRange: [1900, 2099]
                  },
                  formtxn: {
                    custRequired: true,
                    custNum: true,
                    custRange: [1, 1000]
                  },
                  formG: {
                    custLessThan: "#ctrl_txt_GRP"
                  }
                });
                
                
                $( ".resdclass" ).change(function() {
                      
                      var m1;
                      var m2;
                      var m3;
                      var stArr;
                      
                      var vl = $( this ).val();
                      var id = this.id;
                      
                      if (id == "ctrl_dlist_RES")
                      {
                            m1 = $("#ctrl_txt_GRD"); 
                            m2 = $("#ctrl_txt_GRP");
                            m3 = $("#ctrl_txt_GRC");
                            l1 = $("#ctrl_lbl_SLH2");
                            
                      }
                      else
                      {
                            stArr = id.split('_');
                            m1 = $("#ctrlDynamic_txt_GRD_6_" + stArr[4] ); 
                            m2 = $("#ctrlDynamic_txt_GRP_6_" + stArr[4] );
                            m3 = $("#ctrlDynamic_txt_GRC_6_" + stArr[4] );
                            l1 = $("#ctrlDynamic_lbl_SLH_6_" + stArr[4] );
                      }
                      
                      if(vl == "GPA")
                      {
                        m1.val("");
                        
                        m1.hide();
                        m2.show();
                        m3.show();
                        l1.show();
                      }
                      else if (vl == "GRA")
                      {
                        m2.val("");
                        m3.val("");
                        
                        m1.show();
                        m2.hide();
                        m3.hide();
                        l1.hide();
                      }
                      else
                      {
                        m1.val("");
                        m2.val("");
                        m3.val("");
                        
                        m1.hide();
                        m2.hide();
                        m3.hide();
                        l1.hide();
                      }
                      
                });
                
                $( ".educlass" ).change(function() {
                
                      var m1;
                      var stArr;
                      
                      var vl = $( this ).val();
                      var id = this.id;
                      
                      if (id == "ctrl_dlist_EDU")
                      {
                            m1 = $("#ctrl_txt_EDO"); 
                      }
                      else
                      {
                            stArr = id.split('_');
                            m1 = $("#ctrlDynamic_txt_EDO_1_" + stArr[4] ); 
                      }
                                      
                                         
                      if(vl == "OTH")
                      {
                        m1.show();
                      }
                      else
                      {
                        m1.hide();
                        m1.val("")
                      }
                });
                
                $( ".schclass" ).change(function() {
                
                      var m1;
                      var stArr;
                      
                      var vl = $( this ).val();
                      var id = this.id;
                      
                      if (id == "ctrl_dlist_SCH")
                      {
                            m1 = $("#ctrl_txt_SCO"); 
                      }
                      else
                      {
                            stArr = id.split('_');
                            m1 = $("#ctrlDynamic_txt_SCO_2_" + stArr[4] ); 
                      }
                                            
                      if(vl == "OTH")
                      {
                        m1.show();
                      }
                      else
                      {
                        m1.hide();
                        m1.val("")
                      }
                });
                
            });