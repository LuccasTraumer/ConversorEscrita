public class Dicionario implements Cloneable
{
	private static final int TAMANHO = 30;
	private final char alfabeto[] = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','Z',' '};
	private final String morse[] = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--",
                  "-.","---",".--.","--.-",".-.","...","-",
                  "..-","...-",".--","-..-","-.--","--.."," "};
	private String frase;
	private int tamanhoFrase;
	public Dicionario(String fras) throws Exception
	{
		if(fras == null)
			throw new Exception("Valor Nulo!");

		this.frase = fras.toLowerCase();
		this.tamanhoFrase = this.frase.length();

	}

	private int kd(char letra)
	{
		int pos = -1;
		for(int i=0; i < this.tamanhoFrase;i++)
			if(alfabeto[i] == letra){
				pos = i;
				break;
		}
		return pos;
	}
	private boolean tem(char letra)
	{
		boolean tem = false;
		for(int i=0; i < this.tamanhoFrase;i++)
			if(alfabeto[i] == letra)
				tem = true;
		return tem;
	}

	private String conversorMorse()
	{
		String ret = "";
		int pos;
		for(int i=0;i < this.tamanhoFrase;i++)
		{
			pos = this.kd(this.frase.charAt(i));
			if(pos != -1)
				ret = ret + this.morse[pos]+"";
		}

		return ret ;
	}


	public String toString()
	{
		return "A frase: "+this.frase+" Em morse é: " + conversorMorse();
	}
	public Object clone()
	{
		Dicionario ret = null;
		try{
			ret = new Dicionario(this);
			}catch(Exception err){}

		return ret;
	}
	public Dicionario(Dicionario mold) throws Exception
	{
		if(mold == null)
			throw new Exception("Mold Nulo!");

		this.frase = mold.frase;
		this.tamanhoFrase = mold.tamanhoFrase;
	}
	public boolean equals(Object obj)
	{
		if(obj == null)
			return false;
		if(this == obj)
			return true;
		if(this.getClass() != obj.getClass())
			return false;

		Dicionario aux = (Dicionario)obj;

		if(this.tamanhoFrase != aux.tamanhoFrase)
			return false;
		if(!this.frase.equals(aux.frase))
			return false;

		return true;
	}

}