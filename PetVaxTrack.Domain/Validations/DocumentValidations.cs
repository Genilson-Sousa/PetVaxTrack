using PetVaxTrack.Domain.Notifications;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DocumentIsValid(Document document, string message, string propertyName)
        {
            if (document.DocumentType == Enums.EdocumentType.CPF)
            {
                if (!IsCpf(document.DocumentNumber))
                {
                    AddNotification(new Notification(message, propertyName + " (CPF)"));
                }

                if (document.DocumentType == Enums.EdocumentType.CNPJ)
                {
                    if (!isCnpj(document.DocumentNumber))
                    {
                        AddNotification(new Notification(message, propertyName + " (CNPJ)"));
                    }
                }
            }

            return this;
        }
        private bool IsCpf(string cpf)
        {
            cpf = (cpf ?? string.Empty).Replace(".", "").Replace("-", "").Trim();

            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            int[] multiplicador1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string tempCpf;
            string digito;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }


        private bool isCnpj(string cnpj)
        {
            cnpj = (cnpj ?? string.Empty).Replace(".", "").Replace("-", "").Replace("/", "").Trim();

            if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                return false;

            int[] multiplicador1 = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string tempCnpj;
            string digito;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito = resto.ToString();
            tempCnpj += digito;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }
    }
}