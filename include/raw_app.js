﻿
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
                            required: "請填寫英文姓氏 Please enter Family Name"
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
		        });
                        if (this.optional(element)) return true;
                        
                        var mid = element.name;
                        var m1;
                        
                        if(mid == "ctrl_txt_GRC")
		                else
		                {
		                    stArr = mid.split('_');		                    
                            m1 = $("#ctrlDynamic_txt_GRP_6_" + stArr[4] );                            		                
		                }
		                
                        var i = parseFloat(value);
                        var j = parseFloat($(m1).val());
                        
                        return j <= i ;
                }, "*");
		                        stArr = mid.split('_');
		                        curIsGRA = mid.startsWith("#ctrlDynamic_txt_GRD");		                        
                                m1 = $("#ctrlDynamic_dlist_RES_6_" + stArr[4] );                                 
                $.validator.addMethod( 
                    'email',
                    function(value, element){                        
                        return this.optional( element ) || /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/.test( value );
                        //
                    }
                );
                                
                    // param = size (in bytes) 
                    // element = element to validate (<input>)
                    // value = value of the element (file name)
                    return this.optional(element) || (element.files[0].size <= param) 
                });
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