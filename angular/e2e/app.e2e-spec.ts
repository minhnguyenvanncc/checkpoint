import { CheckpointTemplatePage } from './app.po';

describe('Checkpoint App', function() {
  let page: CheckpointTemplatePage;

  beforeEach(() => {
    page = new CheckpointTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
