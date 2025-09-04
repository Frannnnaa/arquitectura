
const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
}); // Interfaz para leer entrada del usuario

console.log("¿Cómo quieres tu botella?");

rl.question("¿Llena o vacía?: ", (respuesta) => {
  const botella = ["llena", "vacía"];

  if (respuesta.toLowerCase() === "llena") {
    console.log(botella[0]);
  } else {
    console.log(botella[1]);
  }
  console.log("Gracias por tu compra");
  rl.close();
});

