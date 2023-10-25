package energia;

import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class Energia extends HttpServlet {

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        double consumo = Double.parseDouble(request.getParameter("kWh"));
        System.out.println(consumo);

        EnergiaModel e1 = new EnergiaModel();
        
        e1.Fornecimento(consumo);
        e1.calcIcms(consumo);
        e1.calcCofins(consumo);
        e1.calcPis(consumo);
        e1.calcIcmsCofins(e1.getCofins(),e1.getIcms(),e1.getFornecimento());
        e1.calcIcmsPis(e1.getPis(), e1.getIcms(), e1.getFornecimento());
            e1.calcFatura( e1.getFornecimento(), e1.getIcms(), 
                    e1.getCofins(), e1.getPis(), e1.getIcms_cofins(), e1.getIcms_pis());


        response.setContentType("text/html;charset=UTF-8");

        try (PrintWriter out = response.getWriter()) {

            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet Energia</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1> Energia  " + request.getContextPath() + " </h1>");
            out.println("<P>O valor do fornecimento é :" + e1.getFornecimento()  + "</P>");
            out.println("<P>O valor do icms é : "+ e1.getIcms() + "</P>");
            out.println("<P>O valor do cofins é :" + e1.getCofins() + "</P>");
            out.println("<P>O valor do Pis Pasep é :" + e1.getPis() + "</P>");
            out.println("<P>O valor do Icms Cofins é : "  + e1.getIcms_cofins() + " </P>");
            out.println("<P>O valor do Icms Pis Pasep é :  " + e1.getIcms_pis()  + "</P>");
            out.println("<P>O valor da fatura é : " + e1.getFatura() + "</P>");
            out.println("</body>");
            out.println("</html>");
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
