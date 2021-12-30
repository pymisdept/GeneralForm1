
            $(function()
            {
            
            var form2  = $("#myform2").validate({
                   rules: {
                        txt_OExpSal: {required: true},
                        dlist_AvaDate: {required: true},
                        txt_AvaDateOthers: {required: true},
                        dlist_WorkingVISA: {required: true},
                        dlist_Vacancy: {required: true},
                        txt_VacancyOthers: {required: true},
                        ctrl_edu_dlist_EDU_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_SCH_1").val()!="" ||  $("#ctrl_edu_txt_PRG_1").val()!="" ||  $("#ctrl_edu_txt_MAJ_1").val()!="" ||  $("#ctrl_edu_txt_GRM_1").val()!="" ||  $("#ctrl_edu_txt_GRY_1").val()!="" ||  $("#ctrl_edu_dlist_RES_1").val()!=""; }},
                        ctrl_edu_txt_EDO_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_dlist_SCH_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_txt_SCO_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_txt_PRG_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_txt_MAJ_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_txt_GRM_1: {custDigits: true,custMinLgt: 2,custMaxLgt: 2,custRange: [1, 12], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; } },
                        ctrl_edu_txt_GRY_1: {custDigits: true,custMinLgt: 4,custMaxLgt: 4,custRange: [1900, 2099], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_dlist_RES_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_txt_GRP_1: {custNum: true, custRange: [1, 1000],custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_txt_GRC_1: {custLessThan: "#ctrl_edu_txt_GRP_1", custNum: true, custRange: [1, 1000], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        ctrl_edu_txt_GRD_1: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_1").val()!=""; }},
                        
                        ctrl_edu_dlist_EDU_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_SCH_2").val()!="" ||  $("#ctrl_edu_txt_PRG_2").val()!="" ||  $("#ctrl_edu_txt_MAJ_2").val()!="" ||  $("#ctrl_edu_txt_GRM_2").val()!="" ||  $("#ctrl_edu_txt_GRY_2").val()!="" ||  $("#ctrl_edu_dlist_RES_2").val()!=""; }},
                        ctrl_edu_txt_EDO_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_dlist_SCH_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_txt_SCO_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_txt_PRG_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_txt_MAJ_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_txt_GRM_2: {custDigits: true,custMinLgt: 2,custMaxLgt: 2,custRange: [1, 12], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; } },
                        ctrl_edu_txt_GRY_2: {custDigits: true,custMinLgt: 4,custMaxLgt: 4,custRange: [1900, 2099], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_dlist_RES_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_txt_GRP_2: {custNum: true, custRange: [1, 1000], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_txt_GRC_2: {custLessThan: "#ctrl_edu_txt_GRP_2", custNum: true, custRange: [1, 1000], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        ctrl_edu_txt_GRD_2: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_2").val()!=""; }},
                        
                        ctrl_edu_dlist_EDU_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_SCH_3").val()!="" ||  $("#ctrl_edu_txt_PRG_3").val()!="" ||  $("#ctrl_edu_txt_MAJ_3").val()!="" ||  $("#ctrl_edu_txt_GRM_3").val()!="" ||  $("#ctrl_edu_txt_GRY_3").val()!="" ||  $("#ctrl_edu_dlist_RES_3").val()!=""; }},
                        ctrl_edu_txt_EDO_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_dlist_SCH_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_txt_SCO_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_txt_PRG_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_txt_MAJ_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_txt_GRM_3: {custDigits: true,custMinLgt: 2,custMaxLgt: 2,custRange: [1, 12], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; } },
                        ctrl_edu_txt_GRY_3: {custDigits: true,custMinLgt: 4,custMaxLgt: 4,custRange: [1900, 2099], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_dlist_RES_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_txt_GRP_3: {custNum: true, custRange: [1, 1000], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_txt_GRC_3: {custLessThan: "#ctrl_edu_txt_GRP_3", custNum: true, custRange: [1, 1000], custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }},
                        ctrl_edu_txt_GRD_3: {custRequired: function(element){ return $("#ctrl_edu_dlist_EDU_3").val()!=""; }}
                   },   
                   messages: {
                        txt_OExpSal: {
                            required: "請填寫資料 Please input data"
                        },
                        dlist_AvaDate: {
                            required: "請選擇 Please select"
                        },
                        txt_AvaDateOthers: {
                            required: "請填寫資料 Please input data"
                        },
                        dlist_WorkingVISA: {
                            required: "請選擇 Please select"
                        },
                        dlist_Vacancy: {
                            required: "請選擇 Please select"
                        },
                        txt_VacancyOthers: {
                            required: "請填寫資料 Please input data"
                        }
                    }
                });
                  		        $.validator.addMethod("custRequired", $.validator.methods.required,"*");		        $.validator.addMethod("custDigits", $.validator.methods.digits,"*");		        $.validator.addMethod("custMinLgt", $.validator.methods.minlength,"*");		        $.validator.addMethod("custMaxLgt", $.validator.methods.maxlength,"*");		        $.validator.addMethod("custRange", $.validator.methods.range,"*");		        $.validator.addMethod("custNum", $.validator.methods.number,"*");		        		        jQuery.validator.addClassRules({
                  formdl: {
                    custRequired: true
                  },
                  formtx: {
                    custRequired: true
                  },
                  formtxm_c: {
                   // custCheckDate: ""
                  },
                  formtxy_c: {
                    custCheckDate: ""
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
                
               $.validator.addMethod("custLessThan",		           function(value, element, param) {
                        if (this.optional(element)) return true;
                        
                        var m1 = $(param);
                                      		                
                        var i = parseFloat(value);
                        var j = parseFloat(m1.val());
                        
                        return j <= i ;
                }, "*");                            
               $.validator.addMethod("custCheckDate",		           function(value, element, param) {
                        if (this.optional(element)) return true;
                        var mid = element.name;
                        var m1,m2;
                        var y1,y2;
                        var stArr;
                        var r;
                        
                        if(mid.indexOf("ctrlDynamic_actv_txt_ACTTYEAR") >= 0)		                {
		                    stArr = mid.split('_');
		                    r = stArr[4];
		                    
		                    m1 = $("#ctrlDynamic_actv_txt_ACTMONTH_" + r + "_3").val();
		                    y1 = $("#ctrlDynamic_actv_txt_ACTYEAR_" + r + "_3").val();
		                    
		                    m2 = $("#ctrlDynamic_actv_txt_ACTMONTH_" + r + "_4").val();
		                    y2 = $("#ctrlDynamic_actv_txt_ACTTYEAR_" + r + "_4").val();		                    
		                }
		                else if(mid.indexOf("ctrlDynamic_job_txt_JOBTYEAR") >= 0)
		                {
		                    stArr = mid.split('_');
		                    r = stArr[4];
		                    
		                    m1 = $("#ctrlDynamic_job_txt_JOBMONTH_" + r + "_3").val();
		                    y1 = $("#ctrlDynamic_job_txt_JOBYEAR_" + r + "_3").val();
		                    
		                    m2 = $("#ctrlDynamic_job_txt_JOBMONTH_" + r + "_4").val();
		                    y2 = $("#ctrlDynamic_job_txt_JOBTYEAR_" + r + "_4").val();                      		                
		                }
		                
		                
		                if(m1 == "" || m2 == "" || y1 == "" || y2 == "")
		                        return true;
		                else
		                {        
                            var sd = new Date(y1, m1 - 1, 1, 0, 0, 0);
                            var ed = new Date(y2, m2 - 1, 1, 0, 0, 0);
                        
                            return ed >= sd ;
                        }
                }, "*");                            
                            
                $('#btnPreview').click(function(e)
                {
                    form2.checkForm();
                });
                                
                $('.nav-link').click(function()
                {
                    form2.checkForm();
                    
                    if($("#myform2").valid())
                    {
                        var cs = $( this ).attr('tseq');
                        $("#navPos").val(cs);
                        
                        return true;
                    }
                    else
                        return false;
                });
                
                 $('.nextbtn a').click(function ()
                 {
                    var ts = $( this ).attr('tsq');
                    var cs = $( this ).attr('csq');
           
                    var currT = $("#vtab" + cs);
                    var currTC = $("#vtabC" + cs);
                    var nextT = $("#vtab" + ts);
                    var nextTC = $("#vtabC" + ts);
                     
                    var prev =  $("#navFpo").val();
                    
                    form2.checkForm();
                    if($("#myform2").valid())
                    {
                        currT.removeClass('active');
                        currT.removeClass('disabled');
                        nextT.addClass('active');
                        nextT.removeClass('disabled');
                        
                        
                        currTC.removeClass('show active');                 
                        nextTC.addClass('show active');
                                                
                        $("#navPos").val(ts);
                                               
                        
                        if(ts > prev)
                        {
                            $("#navFpo").val(ts);                                                    
                        }
                        
                    }
                 });
                
                $( "#dlist_AvaDate" ).change(function() 
                {
                      var vl = $( this ).val();
                      var m1 = $("#txt_AvaDateOthers");
                      
                      if(vl == "OTH")
                      {
                        m1.show();
                      }
                      else
                      {
                        m1.val("");
                        m1.hide();
                      }
                });
                
                
                $( "#dlist_Vacancy" ).change(function() 
                {
                      var vl = $( this ).val();
                      var m1 = $("#txt_VacancyOthers");
                      
                      if(vl == "OTH")
                      {
                        m1.show();
                      }
                      else
                      {
                        m1.val("");
                        m1.hide();
                      }
                });
                
                 $( "#ctrl_edu_dlist_EDU_1" ).change(function() 
                 {
                
                      var vl = $( this ).val();
                      var m1 = $("#ctrl_edu_txt_EDO_1");
                                      
                                         
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
                 $( "#ctrl_edu_dlist_EDU_2" ).change(function() 
                 {
                
                      var vl = $( this ).val();
                      var m1 = $("#ctrl_edu_txt_EDO_2");
                                      
                                         
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
                 $( "#ctrl_edu_dlist_EDU_3" ).change(function() 
                 {
                
                      var vl = $( this ).val();
                      var m1 = $("#ctrl_edu_txt_EDO_3");
                                      
                                         
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
                 $( "#ctrl_edu_dlist_SCH_1" ).change(function() 
                 {
                
                      var vl = $( this ).val();
                      var m1 = $("#ctrl_edu_txt_SCO_1");
                                      
                                         
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
                 $( "#ctrl_edu_dlist_SCH_2" ).change(function() 
                 {
                
                      var vl = $( this ).val();
                      var m1 = $("#ctrl_edu_txt_SCO_2");
                                      
                                         
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
                 $( "#ctrl_edu_dlist_SCH_3" ).change(function() 
                 {
                
                      var vl = $( this ).val();
                      var m1 = $("#ctrl_edu_txt_SCO_3");
                                      
                                         
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
                
                
                $( "#ctrl_edu_dlist_RES_1" ).change(function() {
                      
                      var m1;
                      var m2;
                      var m3;
                      var stArr;
                      
                      var vl = $( this ).val();
                      var id = this.id;
                      
                      m1 = $("#ctrl_edu_txt_GRD_1");
                      m2 = $("#ctrl_edu_txt_GRC_1");
                      m3 = $("#ctrl_edu_txt_GRP_1"); 
                      l1 = $("#ctrl_edu_lbl_SLH_2");
                            
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
                
                $( "#ctrl_edu_dlist_RES_1" ).change(function() {
                      
                      var m1;
                      var m2;
                      var m3;
                      var stArr;
                      
                      var vl = $( this ).val();
                      var id = this.id;
                      
                      m1 = $("#ctrl_edu_txt_GRD_1");
                      m2 = $("#ctrl_edu_txt_GRC_1");
                      m3 = $("#ctrl_edu_txt_GRP_1"); 
                      l1 = $("#ctrl_edu_lbl_SLH_2");
                            
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
                
                $( "#ctrl_edu_dlist_RES_2" ).change(function() {
                      
                      var m1;
                      var m2;
                      var m3;
                      var stArr;
                      
                      var vl = $( this ).val();
                      var id = this.id;
                      
                      m1 = $("#ctrl_edu_txt_GRD_2");
                      m2 = $("#ctrl_edu_txt_GRC_2");
                      m3 = $("#ctrl_edu_txt_GRP_2"); 
                      l1 = $("#ctrl_edu_lbl_SLH_4");
                            
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
                
                $( "#ctrl_edu_dlist_RES_3" ).change(function() {
                      
                      var m1;
                      var m2;
                      var m3;
                      var stArr;
                      
                      var vl = $( this ).val();
                      var id = this.id;
                      
                      m1 = $("#ctrl_edu_txt_GRD_3");
                      m2 = $("#ctrl_edu_txt_GRC_3");
                      m3 = $("#ctrl_edu_txt_GRP_3"); 
                      l1 = $("#ctrl_edu_lbl_SLH_6");
                            
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
                
                
            });
            
            
                function doPreview() {
                    $('#vtabC7').removeClass('show active');
                    $('#vtabC8').addClass('show active');
                    var ts = Date.now();
                    $('#mypreview').empty();
                    $.get('Preview.aspx?' + ts, function (data){ 
                        $('#mypreview').append(data);  
                    });                    
                };
                