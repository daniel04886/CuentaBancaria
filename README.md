# Explicación del Programa Cuenta Bancaria en C#

# Características principales
   #  Clase CuentaBancaria
    Atributos privados: titular (nombre del titular), saldo (cantidad de dinero disponible) y idCuenta (identificador único para cada cuenta).
    Atributo estático contadorCuentas: Se usa para asignar un número único a cada cuenta creada.
    Métodos:
       Depositar(decimal monto): Permite agregar dinero a la cuenta, validando que el monto sea positivo.
       Retirar(decimal monto): Permite retirar dinero si hay fondos suficientes y si el monto es positivo.
       MostrarInformacion(): Muestra los datos de la cuenta, incluyendo ID, titular y saldo.

   # Clase Program (Método Main)
    Se crean tres cuentas bancarias con diferentes titulares y saldos iniciales.
    Se ejecuta un ciclo `while` que muestra un menú de opciones para interactuar con las cuentas.
    Opciones disponibles en el menú:
      Depositar: Solicita al usuario un monto y lo agrega al saldo de la cuenta seleccionada.
      Retirar: Permite al usuario retirar dinero si hay suficiente saldo.
      Mostrar información: Muestra los datos de la cuenta.
      Salir: Termina la ejecución del programa.
    El usuario selecciona una cuenta específica (1, 2 o 3) antes de realizar cualquier operación.

# Ejemplo de Ejecución:
```
Seleccione una opción:
1. Depositar
2. Retirar
3. Mostrar información
4. Salir
Opción: 1
Seleccione cuenta: 1, 2 o 3
1
Ingrese monto a depositar: 500
Depósito de RD$500.00 realizado con éxito en la cuenta 1.

Este programa permite gestionar cuentas bancarias de forma sencilla, asegurando que las operaciones sean válidas y reflejando los cambios en el saldo de manera clara en la consola.
