public class Morse
{
	private final String morse[] = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--",
	                  "-.","---",".--.","--.-",".-.","...","-",
                  "..-","...-",".--","-..-","-.--","--.."," "};
	private String frase;
    public Morse()
    {
		this.frase = "";
	}

	protected String getMorse(int ind)
	{
		this.frase = this.frase + morse[ind];

		return this.frase;
	}

	public String toString()
	{
		Alfabeto alfa = new Alfabeto();
		String ret = "";
		for(int i=0; i < alfa.valores.length;i++)
		{
			int valor = alfa.valores[i];
			ret = ret + morse[valor] + "";
		}

		return ret;
	}
}