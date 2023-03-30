namespace CriadorCaes.Models {

   /// <summary>
   /// descrição dos cães
   /// </summary>
   public class Animais {


      public int Id { get; set; }

      /// <summary>
      /// nome do cão
      /// </summary>
      public string Nome { get; set; }

      /// <summary>
      /// data de nascimento do cão/cadela
      /// </summary>
      public DateTime DataNascimento { get; set; }

      /// <summary>
      /// data de aquisição do cão/cadela
      /// </summary>
      public DateTime DataCompra { get; set; }

      /// <summary>
      /// sexo do animal: 
      /// F - Fêmea
      /// M - Macho
      /// </summary>
      public string Sexo { get; set; }

      /// <summary>
      /// LOP do registo do cão/cadela
      /// </summary>
      public string NumLOP { get; set; }


   }
}
