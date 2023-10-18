package imc;

import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class IMC extends HttpServlet {

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        
        response.setContentType("text/html;charset=UTF-8");
        try {

            Double peso = Double.parseDouble(request.getParameter("Peso"));
            Double altura = Double.parseDouble(request.getParameter("Altura"));
            
            ModeloImc imc = new ModeloImc(peso, altura);
            
            imc.calcularIMC(imc.getPeso(), imc.getAltura());
            imc.classificarIMC(imc.getImc());
            
            try (PrintWriter out = response.getWriter()) {
           
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>IMC</title>");
            out.println("<link rel=\"stylesheet\" href=\"style.css\">");
            out.println("</head>");
            out.println("<body>");
            out.println(" <div class=\"container\">");
            out.println("<div class=\"conteudo\">");
            out.println("<p>Seu imc é de : " + imc.getImc());   
            out.println("<p>Classificação : " + imc.getClassificacao() + "<br><br>");
            out.println("<a href=\"/WebIMC/\"><button class=\"btn\">Voltar</button></a>");
            out.println(" </div>");
            out.println(" </div>");
            out.println("</body>");
            out.println("</html>");
        }
        } catch (NumberFormatException ex) {
            System.out.println("Erro ao converter o numero" + ex.getMessage());
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
