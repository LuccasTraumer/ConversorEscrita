public class Alfabeto
{
	private final char alfabeto[] = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','Z',' '};
	private String frase;
	private int tamanhoFrase;
	int[] valores;
	private int qtd;

	public Alfabeto(String frase) throws Exception
	{
		if(frase == null)
			throw new Exception("Frase nula!");

		this.frase = frase.toLowerCase();
		this.tamanhoFrase = frase.length();
		this.qtd = 0;
		this.valores = new int[this.tamanhoFrase];
	}

	private int kd(char letra)
	{

		int pos = -1;
		for(int i=0; i < this.alfabeto.length;i++)
			if(this.alfabeto[i] == letra)
			{
				pos = i;
				break;
			}

		return pos;
	}
	private String paraMorse()
	{
		String ret = "";
		Morse letras = new Morse();
		for(int i=0; i < this.tamanhoFrase;i++)
		{
			int ind = this.kd(this.alfabeto[i]);
			ret = letras.getMorse(ind);
		}
		return ret;
	}
	protected int[] vetParaMorse() // Vai armazenar as posicoes dos ind do alfabeto no Vetor
	{
		for(int i=0; i < this.tamanhoFrase;i++)
		{
			valores[qtd] = this.kd(this.frase.charAt(i));
			this.qtd++;
		}
		return valores;

	}
	private boolean tem(char letra)
	{

		if(this.kd(letra) == -1)
			return false;

		return true;
	}
	protected Alfabeto()
	{

	}
	public String toString()
	{
		return "Sua Frase foi: "+this.frase;
	}
}