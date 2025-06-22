//codigo original
string mensaje;
if (pagoRealizado)
    mensaje = "Gracias por su compra";
else
    mensaje = "No se ha realizado el pago";
//refactorizado con ternario
mensaje = pagoRealizado ? "Gracias por su compra" : "No se ha realizado el pago";