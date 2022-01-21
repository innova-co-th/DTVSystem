using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Data;
using DTVSystem.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTVSystem.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult SAM0001()
        {
            SAM0001ViewModel model = new SAM0001ViewModel();
            model.Title = "SAM0001 : Component";

            model.Mode = "Add";
            model.CreateInfo = "Create Data.";
            model.UpdateInfo = "Update Data.";

            List<SelectListItem> lstDdlCustomer = new List<SelectListItem>();
            SelectListItem item = new SelectListItem
            {
                Text = "Text1",
                Value = "A001",
            };
            lstDdlCustomer.Add(item);
            model.CustomerListItem = lstDdlCustomer;

            return View(model);
        }

        public IActionResult SAM0010()
        {
            SAM0010ViewModel model = new SAM0010ViewModel();
            model.Title = "SAM0010 : Mas_Company";

            model.Mode = "Add";
            model.CreateInfo = "Create Data.";
            model.UpdateInfo = "Update Data.";

            List<SelectListItem> lstDdlCustomer = new List<SelectListItem>();
            SelectListItem item = new SelectListItem
            {
                Text = "Text1",
                Value = "A001",
            };
            lstDdlCustomer.Add(item);
            model.CompanyModel = new Models.CompanyModel();
            model.CompanyModel.Company_ID = 1;
            model.CompanyModel.Company_name = "DIT";

            model.CompanyModelList = new List<Models.CompanyModel>();
            model.CompanyModelList.Add(model.CompanyModel);

            return View(model);
        }

        public async Task<IActionResult> SAM0011()
        {
            return View();
        }

        [HttpPost]
        public Boolean Save1()
        {
            Boolean result = false;

            return result;
        }

        [HttpPost]
        public JsonResult AjaxMethod()
        {
            return Json("OK");
        }

        //public IActionResult SAM0011()
        //{
        //    SAM0010ViewModel model = new SAM0010ViewModel();
        //    model.Title = "SAM0010";

        //    model.Mode = "Add";
        //    model.CreateInfo = "Create Data.";
        //    model.UpdateInfo = "Update Data.";

        //    List<SelectListItem> lstDdlCustomer = new List<SelectListItem>();
        //    SelectListItem item = new SelectListItem
        //    {
        //        Text = "Text1",
        //        Value = "A001",
        //    };
        //    lstDdlCustomer.Add(item);
        //    //model.CustomerListItem = lstDdlCustomer;

        //    return View(model);
        //}

        public IActionResult PatternList()
        {
            #region Pattern1

            ////string sqlData = _configuration.GetConnectionString("DefaultConnection");
            //string sqlData = "Server=192.168.10.89;Port=5432;User Id=dtvuser;Password=abc123$1;Database=dtvdb";
            //Npgsql.NpgsqlConnection conn = new Npgsql.NpgsqlConnection(sqlData);
            //conn.Open();
            //Npgsql.NpgsqlCommand comm = new Npgsql.NpgsqlCommand();
            //comm.Connection = conn;
            //comm.CommandType = System.Data.CommandType.Text;
            //comm.CommandText = "select * from test";

            ////comm.CommandText = "select * from Department where DepartmentId = @Departmentid";
            ////comm.Parameters.AddWithValue("@Departmentid", id);

            ////var dept = new Department();

            //Npgsql.NpgsqlDataReader sdr = comm.ExecuteReader();
            //while (sdr.Read())
            //{
            //    int i = Convert.ToInt32(sdr["code"]);
            //    string text = (string)sdr["name"];

            //    //dept.DepartmentId = Convert.ToInt32(sdr["DepartmentId"]);
            //    //dept.DepartmentName = sdr["DepartmentName"].ToString();

            //}

            #endregion


            #region Pattern2

            //string strExceptionMsg = "";

            //#region Npgsql
            //NpgsqlConnection conn;
            //conn = new NpgsqlConnection("Server=192.168.10.89;Port=5432;User Id=dtvuser;Password=abc123$1;Database=dtvdb");

            //try
            //{
            //    conn.Open();
            //}
            //catch (NpgsqlException)
            //{
            //    strExceptionMsg = "CouldntOpenConn";
            //    conn.Close();
            //}
            //catch (System.IO.IOException)
            //{
            //    strExceptionMsg = "ConnClosed";
            //    conn.Close();
            //}
            //#endregion

            //string sql = "SELECT code, name FROM test ORDER BY code";

            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count == 0)
            //{
            //    conn.Close();
            //    strExceptionMsg = "No data";
            //}
            //else
            //{
            //    DataRow row = dt.Rows[0];
            //    strExceptionMsg = row["name"].ToString();
            //    conn.Close();
            //}

            #endregion


            #region Pattern3

            string strExceptionMsg = "";
            
            NpgsqlConnection conn = new NpgsqlConnection();

            try
            {
                conn.ConnectionString = "Server=192.168.10.89;Port=5432;User Id=dtvuser;Password=abc123$1;Database=dtvdb";
                //command
                string sql = "SELECT code, name FROM test ORDER BY code";
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    
                    strExceptionMsg = "No data";
                }
                else
                {
                    DataRow row = dt.Rows[0];
                    strExceptionMsg = row["name"].ToString();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion

            return View();
        }
    }
}


//SqlConnection cn = new SqlConnection();
//try
//{
//    cn.ConnectionString = Academia.Model.Dao.Dados.Model_Dao_Dados.getStringDeConexao();
//    //command
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = cn;
//    cmd.CommandText = "insert into produto(descricao,unidade,estoque,valordevenda,observacao) values (@descricao,@unidade,@estoque,@valordevenda,@observacao);";
//    cmd.Parameters.AddWithValue("@descricao", pProduto.Descricao);
//    cmd.Parameters.AddWithValue("@unidade", pProduto.Unidade);
//    cmd.Parameters.AddWithValue("@estoque", pProduto.Estoque);
//    cmd.Parameters.AddWithValue("@valordevenda", pProduto.ValorDeVenda);
//    cmd.Parameters.AddWithValue("@observacao", pProduto.Observacao);
//    cn.Open();
//    pProduto.Id = Convert.ToInt32(cmd.ExecuteScalar());
//}
//catch (SqlException ex)
//{
//    throw new Exception("Servidor SQL Erro:" + ex.Number);
//}
//catch (Exception ex)
//{
//    throw new Exception(ex.Message);
//}
//finally
//{
//    cn.Close();
//}