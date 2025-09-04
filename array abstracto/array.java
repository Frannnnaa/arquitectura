import java.util.Scanner;

public class Botella {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] botella = {"llena", "vacía"};

        System.out.println("¿Cómo quieres tu botella?");
        System.out.print("¿Llena o vacía?: ");
        String respuesta = scanner.nextLine().toLowerCase();

        if (respuesta.equals("llena")) {
            System.out.println(botella[0]);
        } else {
            System.out.println(botella[1]);
        }

        System.out.println("Gracias por tu compra");

        scanner.close();
    }
}
